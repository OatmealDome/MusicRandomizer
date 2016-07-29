using System;

namespace MusicRandomizer
{
    public enum SplatoonRegion
    {
        NorthAmerica = 0,
        Europe = 1,
        Japan = 2
    }

    public class SplatoonRegionTools
    {
        public static String toTitleId(SplatoonRegion region)
        {
            switch (region)
            {
                case SplatoonRegion.NorthAmerica:
                    return "00050000-10176900";
                case SplatoonRegion.Europe:
                    return "00050000-10176A00";
                case SplatoonRegion.Japan:
                    return "00050000-10162B00";
                default:
                    return "";
            }
        }

        public static String toShortName(SplatoonRegion region)
        {
            switch (region)
            {
                case SplatoonRegion.NorthAmerica:
                    return "NA";
                case SplatoonRegion.Europe:
                    return "EU";
                case SplatoonRegion.Japan:
                    return "JP";
                default:
                    return "";
            }
        }
    }

}
