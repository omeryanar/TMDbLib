using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using TMDbLib.Objects.Changes;
using TMDbLib.Objects.General;
using TMDbLib.Objects.Search;
using TMDbLib.Objects.Translations;
using TMDbLib.Utilities.Converters;

namespace TMDbLib.Objects.People
{
    public class Person : SearchPerson
    {
        public new List<SearchMovieTvBase> KnownFor 
        {
            get => KnownForDepartment == "Acting" ? MovieCredits?.Cast?.Cast<SearchMovieTvBase>().Union(TvCredits?.Cast?.Cast<SearchMovieTvBase>())?.OrderByDescending(x => x.VoteAverage * x.VoteCount).Take(8).ToList() :
                MovieCredits?.Crew?.Where(x => x.Department == KnownForDepartment)?.Cast<SearchMovieTvBase>().Union
                (TvCredits?.Crew?.Where(x => x.Department == KnownForDepartment)?.Cast<SearchMovieTvBase>())?.OrderByDescending(x => x.VoteAverage * x.VoteCount).Take(8).ToList();
        }

        [JsonProperty("also_known_as")]
        public List<string> AlsoKnownAs { get; set; }

        [JsonProperty("biography")]
        public string Biography { get; set; }

        [JsonProperty("birthday")]
        [JsonConverter(typeof(TmdbPartialDateConverter))]
        public DateTime? Birthday { get; set; }

        [JsonProperty("changes")]
        public ChangesContainer Changes { get; set; }

        [JsonProperty("deathday")]
        [JsonConverter(typeof(TmdbPartialDateConverter))]
        public DateTime? Deathday { get; set; }

        [JsonProperty("external_ids")]
        public ExternalIdsPerson ExternalIds { get; set; }

        [JsonProperty("homepage")]
        public string Homepage { get; set; }

        [JsonProperty("images")]
        public ProfileImages Images { get; set; }

        [JsonProperty("imdb_id")]
        public string ImdbId { get; set; }

        [JsonProperty("movie_credits")]
        public MovieCredits MovieCredits { get; set; }

        [JsonProperty("place_of_birth")]
        public string PlaceOfBirth { get; set; }

        [JsonProperty("tagged_images")]
        public SearchContainer<TaggedImage> TaggedImages { get; set; }

        [JsonProperty("translations")]
        public TranslationsContainer<TranslationPerson> Translations { get; set; }

        [JsonProperty("tv_credits")]
        public TvCredits TvCredits { get; set; }
    }
}