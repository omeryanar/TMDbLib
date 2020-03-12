using System;
using System.Collections.Generic;
using System.Linq;
using TMDbLib.Client;
using TMDbLib.Objects.General;
using TMDbLib.Objects.Search;
using TMDbLib.Objects.TvShows;
using TMDbLib.Utilities;

namespace TMDbLib.Objects.Discover
{
    public class DiscoverTv : DiscoverBase<SearchTv>
    {
        public DiscoverTv(TMDbClient client)
            : base("discover/tv", client)
        {

        }

        /// <summary>
        /// Only include tv shows that have this company id added as a crew member. Expected value is an integer (the id of a company).
        /// This method performs an AND query.
        /// </summary>
        public DiscoverTv IncludeWithAllOfCompany(IEnumerable<int> companyIds)
        {
            Parameters["with_companies"] = string.Join(",", companyIds.Select(s => s.ToString()));
            return this;
        }

        /// <summary>
        /// Only include tv shows that have this company id added as a crew member.
        /// This method performs an AND query.
        /// </summary>
        public DiscoverTv IncludeWithAllOfCompany(IEnumerable<SearchCompany> companies)
        {
            return IncludeWithAllOfCompany(companies.Select(s => s.Id));
        }

        /// <summary>
        /// Filter TV shows to include a specific network. Expected value is an integer (the id of a network). They can be comma separated to indicate an 'AND' query.
        /// </summary>
        public DiscoverTv IncludeWithAllOfNetwork(IEnumerable<Network> networks)
        {
            return IncludeWithAllOfNetwork(networks.Select(s => s.Id));
        }

        /// <summary>
        /// Filter TV shows to include a specific network. Expected value is an integer (the id of a network). They can be comma separated to indicate an 'AND' query.
        /// </summary>
        public DiscoverTv IncludeWithAllOfNetwork(IEnumerable<int> networkIds)
        {
            Parameters["with_networks"] = string.Join(",", networkIds.Select(s => s.ToString()));
            return this;
        }

        /// <summary>
        /// Only include tv shows with the specified genres. Expected value is an integer (the id of a genre).
        /// This method performs an AND query.
        /// </summary>
        public DiscoverTv IncludeWithAllOfGenre(IEnumerable<int> genreIds)
        {
            Parameters["with_genres"] = string.Join(",", genreIds.Select(s => s.ToString()));
            return this;
        }

        /// <summary>
        /// Only include tv shows with the specified genres.
        /// This method performs an AND query.
        /// </summary>
        public DiscoverTv IncludeWithAllOfGenre(IEnumerable<Genre> genres)
        {
            return IncludeWithAllOfGenre(genres.Select(s => s.Id));
        }

        /// <summary>
        /// Only include tv shows with the specified genres. Expected value is an integer (the id of a genre).
        /// This method performs an AND query.
        /// </summary>
        public DiscoverTv ExcludeWithAllOfGenre(IEnumerable<int> genreIds)
        {
            Parameters["without_genres"] = string.Join(",", genreIds.Select(s => s.ToString()));
            return this;
        }

        /// <summary>
        /// Only include tv shows with the specified genres.
        /// This method performs an AND query.
        /// </summary>
        public DiscoverTv ExcludeWithAllOfGenre(IEnumerable<Genre> genres)
        {
            return ExcludeWithAllOfGenre(genres.Select(s => s.Id));
        }

        /// <summary>
        /// Only include tv shows with the specified keywords. Expected value is an integer (the id of a keyword).
        /// This method performs an AND query.
        /// </summary>
        public DiscoverTv IncludeWithAllOfKeyword(IEnumerable<int> keywordIds)
        {
            Parameters["with_keywords"] = string.Join(",", keywordIds.Select(s => s.ToString()));
            return this;
        }

        /// <summary>
        /// Only include tv shows with the specified keywords.
        /// This method performs an AND query.
        /// </summary>
        public DiscoverTv IncludeWithAllOfKeyword(IEnumerable<SearchKeyword> keywords)
        {
            return IncludeWithAllOfKeyword(keywords.Select(s => s.Id));
        }

        /// <summary>
        /// Only include tv shows with the specified keywords. Expected value is an integer (the id of a keyword).
        /// This method performs an AND query.
        /// </summary>
        public DiscoverTv ExcludeWithAllOfKeyword(IEnumerable<int> keywordIds)
        {
            Parameters["without_keywords"] = string.Join(",", keywordIds.Select(s => s.ToString()));
            return this;
        }

        /// <summary>
        /// Only include tv shows with the specified keywords.
        /// This method performs an AND query.
        /// </summary>
        public DiscoverTv ExcludeWithAllOfKeyword(IEnumerable<SearchKeyword> keywords)
        {
            return ExcludeWithAllOfKeyword(keywords.Select(s => s.Id));
        }

        /// <summary>
        /// Only include tv shows that have this company id added as a crew member. Expected value is an integer (the id of a company).
        /// This method performs an OR query.
        /// </summary>
        public DiscoverTv IncludeWithAnyOfCompany(IEnumerable<int> companyIds)
        {
            Parameters["with_companies"] = string.Join("|", companyIds.Select(s => s.ToString()));
            return this;
        }

        /// <summary>
        /// Only include tv shows that have this company id added as a crew member.
        /// This method performs an OR query.
        /// </summary>
        public DiscoverTv IncludeWithAnyOfCompany(IEnumerable<SearchCompany> companies)
        {
            return IncludeWithAnyOfCompany(companies.Select(s => s.Id));
        }

        /// <summary>
        /// Filter TV shows to include a specific network. Expected value is an integer (the id of a network). They can be pipe separated to indicate an 'OR' query.
        /// </summary>
        public DiscoverTv IncludeWithAnyOfNetwork(IEnumerable<Network> networks)
        {
            return IncludeWithAnyOfNetwork(networks.Select(s => s.Id));
        }

        /// <summary>
        /// Filter TV shows to include a specific network. Expected value is an integer (the id of a network). They can be pipe separated to indicate an 'OR' query.
        /// </summary>
        public DiscoverTv IncludeWithAnyOfNetwork(IEnumerable<int> networkIds)
        {
            Parameters["with_networks"] = string.Join("|", networkIds.Select(s => s.ToString()));
            return this;
        }

        /// <summary>
        /// Only include tv shows with the specified genres. Expected value is an integer (the id of a genre).
        /// This method performs an OR query.
        /// </summary>
        public DiscoverTv IncludeWithAnyOfGenre(IEnumerable<int> genreIds)
        {
            Parameters["with_genres"] = string.Join("|", genreIds.Select(s => s.ToString()));
            return this;
        }

        /// <summary>
        /// Only include tv shows with the specified genres.
        /// This method performs an OR query.
        /// </summary>
        public DiscoverTv IncludeWithAnyOfGenre(IEnumerable<Genre> genres)
        {
            return IncludeWithAnyOfGenre(genres.Select(s => s.Id));
        }

        /// <summary>
        /// Only include tv shows with the specified genres. Expected value is an integer (the id of a genre).
        /// This method performs an OR query.
        /// </summary>
        public DiscoverTv ExcludeWithAnyOfGenre(IEnumerable<int> genreIds)
        {
            Parameters["without_genres"] = string.Join("|", genreIds.Select(s => s.ToString()));
            return this;
        }

        /// <summary>
        /// Only include tv shows with the specified genres.
        /// This method performs an OR query.
        /// </summary>
        public DiscoverTv ExcludeWithAnyOfGenre(IEnumerable<Genre> genres)
        {
            return ExcludeWithAnyOfGenre(genres.Select(s => s.Id));
        }

        /// <summary>
        /// Only include tv shows with the specified keywords. Expected value is an integer (the id of a keyword).
        /// This method performs an OR query.
        /// </summary>
        public DiscoverTv IncludeWithAnyOfKeyword(IEnumerable<int> keywordIds)
        {
            Parameters["with_keywords"] = string.Join("|", keywordIds.Select(s => s.ToString()));
            return this;
        }

        /// <summary>
        /// Only include tv shows with the specified keywords.
        /// This method performs an OR query.
        /// </summary>
        public DiscoverTv IncludeWithAnyOfKeyword(IEnumerable<SearchKeyword> keywords)
        {
            return IncludeWithAnyOfKeyword(keywords.Select(s => s.Id));
        }

        /// <summary>
        /// Exclude tv shows with the specified keywords. Expected value is an integer (the id of a keyword).
        /// This method performs an OR query.
        /// </summary>
        public DiscoverTv ExcludeWithAnyOfKeyword(IEnumerable<int> keywordIds)
        {
            Parameters["without_keywords"] = string.Join("|", keywordIds.Select(s => s.ToString()));
            return this;
        }

        /// <summary>
        /// Only include tv shows with the specified keywords.
        /// This method performs an OR query.
        /// </summary>
        public DiscoverTv ExcludeWithAnyOfKeyword(IEnumerable<SearchKeyword> keywords)
        {
            return ExcludeWithAnyOfKeyword(keywords.Select(s => s.Id));
        }

        /// <summary>
        /// Available options are vote_average.desc, vote_average.asc, first_air_date.desc, first_air_date.asc, popularity.desc, popularity.asc
        /// </summary>
        public DiscoverTv OrderBy(DiscoverTvShowSortBy sortBy)
        {
            Parameters["sort_by"] = sortBy.GetDescription();
            return this;
        }

        /// <summary>
        /// Available options are vote_average.desc, vote_average.asc, first_air_date.desc, first_air_date.asc, popularity.desc, popularity.asc
        /// </summary>
        public DiscoverTv OrderBy(string sortBy)
        {
            DiscoverTvShowSortBy tvShowSortBy = DiscoverTvShowSortBy.PopularityDesc;
            Enum.TryParse(sortBy, true, out tvShowSortBy);

            return OrderBy(tvShowSortBy);
        }

        /// <summary>
        /// Specify a timeone to calculate proper date offsets. A list of valid timezones can be found by using the timezones/list method.
        /// </summary>
        public DiscoverTv UseTimezone(string timezone)
        {
            Parameters["timezone"] = timezone;
            return this;
        }

        /// <summary>
        /// Only include tv shows with the specified genre. Expected value is an integer (the id of a genre).
        /// </summary>
        public DiscoverTv WhereGenreIs(int genreId)
        {
            Parameters["with_genres"] = genreId.ToString();
            return this;
        }

        /// <summary>
        /// Only include tv shows with the specified genre.
        /// </summary>
        public DiscoverTv WhereGenreIs(Genre genre)
        {
            return WhereGenreIs(genre.Id);
        }

        /// <summary>
        /// The minimum episode air date to include. Expected format is YYYY-MM-DD. Can be used in conjunction with a specified timezone.
        /// </summary>
        public DiscoverTv WhereAirDateIsAfter(DateTime date)
        {
            Parameters["air_date.gte"] = date.ToString("yyyy-MM-dd");
            return this;
        }

        /// <summary>
        /// The maximum episode air date to include. Expected format is YYYY-MM-DD. Can be used in conjunction with a specified timezone.
        /// </summary>
        public DiscoverTv WhereAirDateIsBefore(DateTime date)
        {
            Parameters["air_date.lte"] = date.ToString("yyyy-MM-dd");
            return this;
        }

        /// <summary>
        /// The minimum release to include. Expected format is YYYY-MM-DD.
        /// </summary>
        public DiscoverTv WhereFirstAirDateIsAfter(DateTime date)
        {
            Parameters.Remove("first_air_date_year");

            Parameters["first_air_date.gte"] = date.ToString("yyyy-MM-dd");
            return this;
        }

        /// <summary>
        /// The maximum release to include. Expected format is YYYY-MM-DD.
        /// </summary>
        public DiscoverTv WhereFirstAirDateIsBefore(DateTime date)
        {
            Parameters.Remove("first_air_date_year");

            Parameters["first_air_date.lte"] = date.ToString("yyyy-MM-dd");
            return this;
        }

        /// <summary>
        /// Filter the results release dates to matches that include this value. Expected value is a year.
        /// </summary>
        public DiscoverTv WhereFirstAirDateIsInYear(int year)
        {
            Parameters.Remove("first_air_date.gte");
            Parameters.Remove("first_air_date.lte");

            Parameters["first_air_date_year"] = year.ToString("0000");
            return this;
        }

        /// <summary>
        /// Only include TV shows that are equal to, or have a higher average rating than this value. Expected value is a float.
        /// </summary>
        public DiscoverTv WhereVoteAverageIsAtLeast(double score)
        {
            // TODO: Apply culture to the ToString
            Parameters["vote_average.gte"] = score.ToString();
            return this;
        }

        /// <summary>
        /// Only include TV shows that are equal to, or have a vote count higher than this value. Expected value is an integer.
        /// </summary>
        public DiscoverTv WhereVoteCountIsAtLeast(int count)
        {
            Parameters["vote_count.gte"] = count.ToString();
            return this;
        }

        /// <summary>
        /// Specifies which language to use for translatable fields
        /// </summary>
        public DiscoverTv WhereOriginalLanguageIs(string language)
        {
            Parameters["with_original_language"] = language;
            return this;
        }

        /// <summary>
        /// Filter tv shows by their runtime and only include tv shows that have a runtime that is equal to or lower than the specified value.
        /// </summary>
        public DiscoverTv WhereRuntimeIsAtLeast(int runtime)
        {
            Parameters["with_runtime.gte"] = runtime.ToString();
            return this;
        }

        /// <summary>
        /// Filter tv shows by their runtime and only include tv shows that have a runtime that is equal to or lower than the specified value. Expected value is an integer.
        /// </summary>
        public DiscoverTv WhereRuntimeIsAtMost(int runtime)
        {
            Parameters["with_runtime.lte"] = runtime.ToString();
            return this;
        }
    }
}