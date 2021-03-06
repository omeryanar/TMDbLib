using System.Collections.Generic;
using Newtonsoft.Json;
using TMDbLib.Objects.General;
using TMDbLib.Objects.People;

namespace TMDbLib.Objects.Search
{
    public class SearchPerson : SearchBase
    {
        public SearchPerson()
        {
            MediaType = MediaType.Person;
        }

        [JsonProperty("adult")]
        public bool Adult { get; set; }

        [JsonProperty("gender")]
        public PersonGender Gender { get; set; }

        [JsonProperty("known_for")]
        public List<SearchBase> KnownFor { get; set; }

        [JsonProperty("known_for_department")]
        public string KnownForDepartment { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("profile_path")]
        public string ProfilePath { get; set; }
    }
}