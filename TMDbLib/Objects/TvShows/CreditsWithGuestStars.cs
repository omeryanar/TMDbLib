using System.Collections.Generic;
using Newtonsoft.Json;
using TMDbLib.Objects.General;

namespace TMDbLib.Objects.TvShows
{
    public class CreditsWithGuestStars : Credits
    {
        [JsonProperty("guest_stars")]
        public List<Cast> GuestStars { get; set; }
    }
}