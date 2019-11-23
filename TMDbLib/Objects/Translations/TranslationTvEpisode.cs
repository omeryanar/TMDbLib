using Newtonsoft.Json;

namespace TMDbLib.Objects.Translations
{
    public class TranslationTvEpisode
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("overview")]
        public string Overview { get; set; }
    }
}
