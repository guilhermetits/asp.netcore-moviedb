using System.Collections.Generic;
using System.Threading.Tasks;
using MovieDb.Entity;

namespace MovieDb.Data.Rest
{
    public interface IMovieRestClient
    {
        Task<PagedDataResponse<Movie>> GetPopularMovies(int page);
    }
}