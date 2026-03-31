using MovieApp_API.Models;

namespace MovieApp_API.Repository
{
    public interface IMovieRepository
    {
        void Add(Movie obj);
        void Update(Movie obj);
        Movie GetById(int id);
        List<Movie> GetAll();
        void Delete(int id);
        void Save();
    }
}