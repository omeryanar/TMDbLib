using Newtonsoft.Json;

namespace TMDbLib.Objects.Translations
{
    public class TranslationPerson
    {
        [JsonProperty("biography")]
        public string Biography { get; set; }
    }
}
