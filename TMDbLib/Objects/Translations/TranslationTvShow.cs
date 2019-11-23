using Newtonsoft.Json;

namespace TMDbLib.Objects.Translations
{
    public class TranslationTvShow
    {
        [JsonProperty("homepage")]
        public string Homepage { get; set; }        

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("overview")]
        public string Overview { get; set; }
    }
}
