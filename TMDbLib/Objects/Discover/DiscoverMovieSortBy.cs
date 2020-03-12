using System;
using TMDbLib.Utilities;

namespace TMDbLib.Objects.Discover
{
    public enum DiscoverMovieSortBy
    {
        [Obsolete]
        Undefined,
        [EnumValue("popularity.asc")]
        PopularityAsc,
        [EnumValue("popularity.desc")]
        PopularityDesc,
        [EnumValue("release_date.asc")]
        ReleaseDateAsc,
        [EnumValue("release_date.desc")]
        ReleaseDateDesc,
        [EnumValue("revenue.asc")]
        RevenueAsc,
        [EnumValue("revenue.desc")]
        RevenueDesc,
        [EnumValue("primary_release_date.asc")]
        PrimaryReleaseDateAsc,
        [EnumValue("primary_release_date.desc")]
        PrimaryReleaseDateDesc,
        [EnumValue("original_title.asc")]
        OriginalTitleAsc,
        [EnumValue("original_title.desc")]
        OriginalTitleDesc,
        [EnumValue("vote_average.asc")]
        VoteAverageAsc,
        [EnumValue("vote_average.desc")]
        VoteAverageDesc,
        [EnumValue("vote_count.asc")]
        VoteCountAsc,
        [EnumValue("vote_count.desc")]
        VoteCountDesc
    }
}
