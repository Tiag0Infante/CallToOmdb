using Newtonsoft.Json;

namespace CallToOmdb.Models
{
    public class ResponseModel
    {
        [JsonProperty("Title", NullValueHandling = NullValueHandling.Ignore)]
        public string? Title { get; set; }

        [JsonProperty("Year", NullValueHandling = NullValueHandling.Ignore)]
        public string? Year { get; set; }

        [JsonProperty("Rated", NullValueHandling = NullValueHandling.Ignore)]
        public string? Rated { get; set; }

        [JsonProperty("Released", NullValueHandling = NullValueHandling.Ignore)]
        public string? Released { get; set; }

        [JsonProperty("Runtime", NullValueHandling = NullValueHandling.Ignore)]
        public string? Runtime { get; set; }

        [JsonProperty("Genre", NullValueHandling = NullValueHandling.Ignore)]
        public string? Genre { get; set; }

        [JsonProperty("Director", NullValueHandling = NullValueHandling.Ignore)]
        public string? Director { get; set; }

        [JsonProperty("Writer", NullValueHandling = NullValueHandling.Ignore)]
        public string? Writer { get; set; }

        [JsonProperty("Actors", NullValueHandling = NullValueHandling.Ignore)]
        public string? Actors { get; set; }

        [JsonProperty("Plot", NullValueHandling = NullValueHandling.Ignore)]
        public string? Plot { get; set; }

        [JsonProperty("Language", NullValueHandling = NullValueHandling.Ignore)]
        public string? Language { get; set; }

        [JsonProperty("Country", NullValueHandling = NullValueHandling.Ignore)]
        public string? Country { get; set; }

        [JsonProperty("Awards", NullValueHandling = NullValueHandling.Ignore)]
        public string? Awards { get; set; }

        [JsonProperty("Poster", NullValueHandling = NullValueHandling.Ignore)]
        public string? Poster { get; set; }

        [JsonProperty("Ratings", NullValueHandling = NullValueHandling.Ignore)]
        public Rating[]? Ratings { get; set; }

        [JsonProperty("Metascore", NullValueHandling = NullValueHandling.Ignore)]
        
        public string? Metascore { get; set; }

        [JsonProperty("imdbRating", NullValueHandling = NullValueHandling.Ignore)]
        public string? ImdbRating { get; set; }

        [JsonProperty("imdbVotes", NullValueHandling = NullValueHandling.Ignore)]
        public string? ImdbVotes { get; set; }

        [JsonProperty("imdbID", NullValueHandling = NullValueHandling.Ignore)]
        public string? ImdbId { get; set; }

        [JsonProperty("Type", NullValueHandling = NullValueHandling.Ignore)]
        public string? Type { get; set; }

        [JsonProperty("DVD", NullValueHandling = NullValueHandling.Ignore)]
        public string? Dvd { get; set; }

        [JsonProperty("BoxOffice", NullValueHandling = NullValueHandling.Ignore)]
        public string? BoxOffice { get; set; }

        [JsonProperty("Production", NullValueHandling = NullValueHandling.Ignore)]
        public string? Production { get; set; }

        [JsonProperty("Website", NullValueHandling = NullValueHandling.Ignore)]
        public string? Website { get; set; }

        [JsonProperty("Response", NullValueHandling = NullValueHandling.Ignore)]
        public string? Response { get; set; }
    }
    public partial class Rating
    {
        [JsonProperty("Source", NullValueHandling = NullValueHandling.Ignore)]
        public string Source { get; set; }

        [JsonProperty("Value", NullValueHandling = NullValueHandling.Ignore)]
        public string Value { get; set; }
    }
}
