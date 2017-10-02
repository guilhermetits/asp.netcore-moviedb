using MovieDb.Entity;

namespace MovieDb.Web.Models.Mapper
{
    public class ViewModelMapperProfile : AutoMapper.Profile
    {
        public ViewModelMapperProfile()
        {
            CreateMap<PagedDataResponse<Movie>, MovieListViewModel>();
        }
    }
}