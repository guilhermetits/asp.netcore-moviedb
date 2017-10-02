using System.Collections.Generic;

namespace MovieDb.Entity
{
    public class PagedDataResponse<T>
    {
        public int Page { get; set; }
        public IEnumerable<T> Result { get; set; }

        public int TotalPages { get; set; }
    }
}