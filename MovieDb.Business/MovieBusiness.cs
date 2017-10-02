using System;
using System.Threading.Tasks;
using MovieDb.Data.Rest;
using MovieDb.Entity;

namespace MovieDb.Business
{
    public class MovieBusiness
    {
        private readonly MovieRestClient movieRestClient;
        public MovieBusiness(MovieRestClient movieRestClient)
        {
            this.movieRestClient = movieRestClient;
        }

        public async Task<PagedDataResponse<Movie>> GetPopularMovies(int page = 1)
        {
            return await this.movieRestClient.GetPopularMovies(page);
        }
    }
}