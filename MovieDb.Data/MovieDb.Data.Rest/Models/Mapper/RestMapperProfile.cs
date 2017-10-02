using MovieDb.Entity;

namespace MovieDb.Data.Rest.Models.Mapper
{
    public class RestMapperProfile : AutoMapper.Profile
    {
        public RestMapperProfile()
        {
            CreateMap<PopularMovieResponse, PagedDataResponse<Movie>>();
            CreateMap<PopularMovie, Movie>()
            .ForMember(x => x.Popular, x => x.UseValue(true));
        }
    }
}