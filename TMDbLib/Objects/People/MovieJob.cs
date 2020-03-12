using Newtonsoft.Json;
using TMDbLib.Objects.Search;

namespace TMDbLib.Objects.People
{
    public class MovieJob : SearchMovie
    {
        [JsonProperty("credit_id")]
        public string CreditId { get; set; }

        [JsonProperty("department")]
        public string Department { get; set; }

        [JsonProperty("job")]
        public string Job { get; set; }
    }
}