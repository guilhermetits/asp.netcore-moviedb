using System;
using System.Collections.Generic;
using RestSharp.Deserializers;

namespace MovieDb.Data.Rest.Models
{
    internal class PopularMovie
    {
        [DeserializeAs(Name = "id")]
        public int Id { get; set; }
        [DeserializeAs(Name = "video")]
        public bool Video { get; set; }
        [DeserializeAs(Name = "vote_count")]
        public int VoteCount { get; set; }
        [DeserializeAs(Name = "vote_average")]
        public double VoteAverage { get; set; }
        [DeserializeAs(Name = "title")]
        public string Title { get; set; }
        [DeserializeAs(Name = "popularity")]
        public double Popularity { get; set; }
        [DeserializeAs(Name = "poster_path")]
        public string PosterPath { get; set; }
        [DeserializeAs(Name = "original_language")]
        public string OriginalLanguage { get; set; }
        [DeserializeAs(Name = "original_title")]
        public string OriginalTitle { get; set; }
        [DeserializeAs(Name = "genre_ids")]
        public List<int> GenreIds { get; set; }
        [DeserializeAs(Name = "backdrop_path")]
        public string BackdropPath { get; set; }
        [DeserializeAs(Name = "adult")]
        public bool Adult { get; set; }
        [DeserializeAs(Name = "overview")]
        public string Overview { get; set; }
        [DeserializeAs(Name = "release_date")]
        public DateTime ReleaseDate { get; set; }
    }
}