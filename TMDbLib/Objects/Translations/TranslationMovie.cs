using Newtonsoft.Json;

namespace TMDbLib.Objects.Translations
{
    public class TranslationMovie
    {
        [JsonProperty("homepage")]
        public string Homepage { get; set; }

        [JsonProperty("overview")]
        public string Overview { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }
}
