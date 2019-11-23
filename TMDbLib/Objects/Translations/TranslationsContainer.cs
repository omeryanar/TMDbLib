using System.Collections.Generic;
using Newtonsoft.Json;

namespace TMDbLib.Objects.Translations
{
    public class TranslationsContainer<T>
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("translations")]
        public List<Translation<T>> Translations { get; set; }
    }
}