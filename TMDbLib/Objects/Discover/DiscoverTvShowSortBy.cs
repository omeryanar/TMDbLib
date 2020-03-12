using System;
using TMDbLib.Utilities;

namespace TMDbLib.Objects.Discover
{
    public enum DiscoverTvShowSortBy
    {
        [Obsolete]
        Undefined,
        [EnumValue("vote_average.asc")]
        VoteAverageAsc,
        [EnumValue("vote_average.desc")]
        VoteAverageDesc,
        [EnumValue("first_air_date.asc")]
        FirstAirDateAsc,
        [EnumValue("first_air_date.desc")]
        FirstAirDateDesc,
        [EnumValue("popularity.asc")]
        PopularityAsc,
        [EnumValue("popularity.desc")]
        PopularityDesc
    }
}
