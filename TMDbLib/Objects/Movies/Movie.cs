using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using TMDbLib.Objects.Changes;
using TMDbLib.Objects.General;
using TMDbLib.Objects.Reviews;
using TMDbLib.Objects.Search;
using TMDbLib.Objects.Translations;

namespace TMDbLib.Objects.Movies
{
    public class Movie : SearchMovie
    {
        public new List<int> GenreIds { get => Genres?.Select(x => x.Id).ToList(); }

        [JsonProperty("account_states")]
        public AccountState AccountStates { get; set; }

        [JsonProperty("alternative_titles")]
        public AlternativeTitles AlternativeTitles { get; set; }

        [JsonProperty("belongs_to_collection")]
        public SearchCollection BelongsToCollection { get; set; }

        [JsonProperty("budget")]
        public long Budget { get; set; }

        [JsonProperty("changes")]
        public ChangesContainer Changes { get; set; }

        [JsonProperty("credits")]
        public Credits Credits { get; set; }

        [JsonProperty("genres")]
        public List<Genre> Genres { get; set; }

        [JsonProperty("homepage")]
        public string Homepage { get; set; }

        [JsonProperty("images")]
        public Images Images { get; set; }

        [JsonProperty("imdb_id")]
        public string ImdbId { get; set; }

        [JsonProperty("keywords")]
        public KeywordsContainer Keywords { get; set; }

        [JsonProperty("lists")]
        public SearchContainer<ListResult> Lists { get; set; }

        [JsonProperty("production_companies")]
        public List<ProductionCompany> ProductionCompanies { get; set; }

        [JsonProperty("production_countries")]
        public List<ProductionCountry> ProductionCountries { get; set; }

        [JsonProperty("release_dates")]
        public ResultContainer<ReleaseDatesContainer> ReleaseDates { get; set; }

        [JsonProperty("external_ids")]
        public ExternalIdsMovie ExternalIds { get; set; }

        [JsonProperty("releases")]
        public Releases Releases { get; set; }

        [JsonProperty("revenue")]
        public long Revenue { get; set; }

        [JsonProperty("reviews")]
        public SearchContainer<ReviewBase> Reviews { get; set; }

        [JsonProperty("runtime")]
        public int? Runtime { get; set; }

        [JsonProperty("similar")]
        public SearchContainer<SearchMovie> Similar { get; set; }

        [JsonProperty("recommendations")]
        public SearchContainer<SearchMovie> Recommendations { get; set; }

        [JsonProperty("spoken_languages")]
        public List<SpokenLanguage> SpokenLanguages { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("tagline")]
        public string Tagline { get; set; }

        [JsonProperty("translations")]
        public TranslationsContainer<TranslationMovie> Translations { get; set; }

        [JsonProperty("videos")]
        public ResultContainer<Video> Videos { get; set; }
    }
}