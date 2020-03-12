using Newtonsoft.Json;
using TMDbLib.Objects.Search;

namespace TMDbLib.Objects.People
{
    public class TvJob : SearchTv
    {
        [JsonProperty("credit_id")]
        public string CreditId { get; set; }

        [JsonProperty("department")]
        public string Department { get; set; }

        [JsonProperty("episode_count")]
        public int EpisodeCount { get; set; }

        [JsonProperty("job")]
        public string Job { get; set; }
    }
}