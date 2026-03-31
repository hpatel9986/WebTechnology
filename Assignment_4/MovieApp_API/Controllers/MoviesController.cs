using Microsoft.AspNetCore.Mvc;
using MovieApp_API.DTOs;
using MovieApp_API.Models;
using MovieApp_API.Repository;

namespace MovieApp_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly IMovieRepository _repo;

        public MoviesController(IMovieRepository repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public IActionResult GetAll(int pageNumber = 1, int pageSize = 5)
        {
            var all = _repo.GetAll();

            var totalRecords = all.Count;
            var totalPages = (int)Math.Ceiling((double)totalRecords / pageSize);

            var data = all
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize)
                .Select(m => new MovieReadDto
                {
                    Id = m.Id,
                    Title = m.Title,
                    ReleaseYear = m.ReleaseYear,
                    Genre = m.Genre,
                    ImgUrl = m.ImgUrl
                });

            return Ok(new
            {
                pageNumber,
                pageSize,
                totalRecords,
                totalPages,
                data
            });
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var movie = _repo.GetById(id);
            if (movie == null) return NotFound();

            return Ok(movie);
        }

        [HttpPost]
        public IActionResult Create(MovieCreateDto dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var movie = new Movie
            {
                Title = dto.Title,
                ReleaseYear = dto.ReleaseYear,
                Genre = dto.Genre,
                ImgUrl = dto.ImgUrl
            };

            _repo.Add(movie);
            _repo.Save();

            return CreatedAtAction(nameof(GetById), new { id = movie.Id }, movie);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, MovieUpdateDto dto)
        {
            var movie = _repo.GetById(id);
            if (movie == null) return NotFound();

            movie.Title = dto.Title;
            movie.ReleaseYear = dto.ReleaseYear;
            movie.Genre = dto.Genre;
            movie.ImgUrl = dto.ImgUrl;

            _repo.Update(movie);
            _repo.Save();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var movie = _repo.GetById(id);
            if (movie == null) return NotFound();

            _repo.Delete(id);
            _repo.Save();

            return NoContent();
        }
    }
}