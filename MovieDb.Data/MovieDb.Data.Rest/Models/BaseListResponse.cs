using System.Collections.Generic;
using RestSharp.Deserializers;

namespace MovieDb.Data.Rest.Models
{
    internal class BaseListResponse<T>
    {
        [DeserializeAs(Name = "page")]
        public int Page { get; set; }
        [DeserializeAs(Name = "results")]
        public List<T> Result { get; set; }
        [DeserializeAs(Name = "total_pages")]
        public int TotalPages { get; set; }
        [DeserializeAs(Name = "total_results")]
        public int TotalResults { get; set; }
    }
}