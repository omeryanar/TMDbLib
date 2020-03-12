using Newtonsoft.Json;
using TMDbLib.Objects.Search;

namespace TMDbLib.Objects.People
{
    public class MovieRole : SearchMovie
    {
        [JsonProperty("character")]
        public string Character { get; set; }

        [JsonProperty("credit_id")]
        public string CreditId { get; set; }
    }
}