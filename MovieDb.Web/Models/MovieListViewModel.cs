using System.Collections.Generic;

namespace MovieDb.Web.Models
{
    public class MovieListViewModel
    {
        public int Page { get; set; }
        public IEnumerable<MovieViewModel> Result { get; set; }

        public int TotalPages { get; set; }
    
    }
}