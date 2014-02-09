using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CSVReader.Models.Factories
{
    public static class DragonFactory
    {
        private const int NAME_POSITION = 0;
        private const int AGE_POSITION = 1;
        private const int TWITTER_POSITION = 2;
        private const int TYPE_POSITION = 3;

        public static Dragon ParseDragon(string dragonRow)
        {
            string[] dragonData;

            if (ValidateDragonData(dragonRow, out dragonData))
            {
                return new Dragon()
                {
                    Name = dragonData[NAME_POSITION],
                    Age = int.Parse(dragonData[AGE_POSITION]),
                    Twitter = EnsureTwitterHandleFormat(dragonData[TWITTER_POSITION]),
                    Type = ApplyDragonTypeDefaults(dragonData[TYPE_POSITION])
                };
            }

            return null;
        }

        private static bool ValidateDragonData(string dragonRow, out string[] dragonData)
        {
            if (string.IsNullOrEmpty(dragonRow))
            {
                dragonData = new string[0];
                return false;
            }

            dragonData = dragonRow.Split(',');
            if (dragonData.Length != 4)
                return false;

            if (!IsValidAge(dragonData[AGE_POSITION]))
                return false;

            return true;
        }

        private static bool IsValidAge(string value)
        {
            int temp;
            return int.TryParse(value, out temp);
        }

        private static string EnsureTwitterHandleFormat(string value)
        {
            if (!value.StartsWith("@"))
                return string.Concat("@", value);

            return value;
        }

        private static string ApplyDragonTypeDefaults(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                return "Unknown";

            return value;
        }
    }
}