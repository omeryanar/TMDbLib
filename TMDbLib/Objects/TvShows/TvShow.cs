using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using TMDbLib.Objects.Changes;
using TMDbLib.Objects.General;
using TMDbLib.Objects.Search;
using TMDbLib.Objects.Translations;
using TMDbLib.Utilities.Converters;

namespace TMDbLib.Objects.TvShows
{
    public class TvShow : SearchTv
    {
        public new List<int> GenreIds { get => Genres?.Select(x => x.Id).ToList(); }

        [JsonProperty("account_states")]
        public AccountState AccountStates { get; set; }

        [JsonProperty("alternative_titles")]
        public ResultContainer<AlternativeTitle> AlternativeTitles { get; set; }

        [JsonProperty("changes")]
        public ChangesContainer Changes { get; set; }

        [JsonProperty("content_ratings")]
        public ResultContainer<ContentRating> ContentRatings { get; set; }

        [JsonProperty("created_by")]
        public List<CreatedBy> CreatedBy { get; set; }

        [JsonProperty("credits")]
        public Credits Credits { get; set; }

        [JsonProperty("episode_run_time")]
        public List<int> EpisodeRunTime { get; set; }

        [JsonProperty("external_ids")]
        public ExternalIdsTvShow ExternalIds { get; set; }

        [JsonProperty("genres")]
        public List<Genre> Genres { get; set; }

        [JsonProperty("homepage")]
        public string Homepage { get; set; }

        [JsonProperty("images")]
        public Images Images { get; set; }

        [JsonProperty("in_production")]
        public bool InProduction { get; set; }

        [JsonProperty("keywords")]
        public ResultContainer<Keyword> Keywords { get; set; }

        /// <summary>
        /// language ISO code ex. en
        /// </summary>
        [JsonProperty("languages")]
        public List<string> Languages { get; set; }

        [JsonProperty("last_air_date")]
        public DateTime? LastAirDate { get; set; }

        [JsonProperty("last_episode_to_air")]
        public TvEpisodeBase LastEpisodeToAir { get; set; }

        [JsonProperty("next_episode_to_air")]
        public TvEpisodeBase NextEpisodeToAir { get; set; }

        [JsonProperty("networks")]
        public List<NetworkWithLogo> Networks { get; set; }

        [JsonProperty("number_of_episodes")]
        [JsonConverter(typeof(TmdbNullIntAsZero))]
        public int NumberOfEpisodes { get; set; }

        [JsonProperty("number_of_seasons")]
        [JsonConverter(typeof(TmdbNullIntAsZero))]
        public int NumberOfSeasons { get; set; }

        [JsonProperty("production_companies")]
        public List<ProductionCompany> ProductionCompanies { get; set; }

        [JsonProperty("seasons")]
        public List<SearchTvSeason> Seasons { get; set; }

        [JsonProperty("similar")]
        public ResultContainer<SearchTv> Similar { get; set; }

        [JsonProperty("recommendations")]
        public ResultContainer<SearchTv> Recommendations { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("translations")]
        public TranslationsContainer<TranslationTvShow> Translations { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("videos")]
        public ResultContainer<Video> Videos { get; set; }
    }
}