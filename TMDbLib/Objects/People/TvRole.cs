using Newtonsoft.Json;
using TMDbLib.Objects.Search;

namespace TMDbLib.Objects.People
{
    public class TvRole : SearchTv
    {
        [JsonProperty("character")]
        public string Character { get; set; }

        [JsonProperty("credit_id")]
        public string CreditId { get; set; }

        [JsonProperty("episode_count")]
        public int EpisodeCount { get; set; }
    }
}