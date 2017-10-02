using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.Extensions.Configuration;
using MovieDb.Data.Rest.Models;
using MovieDb.Entity;

namespace MovieDb.Data.Rest
{
    public class MovieRestClient : BaseRestClient, IMovieRestClient
    {
        private readonly IMapper mapper;

        public MovieRestClient(IConfiguration configuration, IMapper mapper) : base(configuration)
        {
            this.mapper = mapper;
        }

        public async Task<PagedDataResponse<Movie>> GetPopularMovies(int page)
        {
            var request = this.CreateRequest("/movie/popular");
            request.AddUrlSegment("page", page.ToString());
            var response = await this.ExecuteRequestAsync<PopularMovieResponse>(request);

            return mapper.Map<PagedDataResponse<Movie>>(response.Data);
        }
    }
}