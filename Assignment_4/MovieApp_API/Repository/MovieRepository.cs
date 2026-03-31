using MovieApp_API.Models;

namespace MovieApp_API.Repository
{
    public class MovieRepository : IMovieRepository
    {
        private readonly AppDbContext _db;

        public MovieRepository(AppDbContext context)
        {
            _db = context;
        }

        public void Add(Movie obj)
        {
            _db.Movies.Add(obj);
        }

        public void Update(Movie obj)
        {
            _db.Movies.Update(obj);
        }

        public Movie GetById(int id)
        {
            return _db.Movies.FirstOrDefault(m => m.Id == id);
        }

        public List<Movie> GetAll()
        {
            return _db.Movies.ToList();
        }

        public void Delete(int id)
        {
            var movie = GetById(id);
            if (movie != null)
                _db.Movies.Remove(movie);
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}