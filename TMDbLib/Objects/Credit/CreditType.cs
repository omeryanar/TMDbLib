using TMDbLib.Utilities;

namespace TMDbLib.Objects.Credit
{
    public enum CreditType
    {
        Unknown,

        [EnumValue("crew")]
        Crew = 1,

        [EnumValue("cast")]
        Cast = 2
    }
}