using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketMachine.Util;

namespace TicketMachine.Model
{
    public static class StationFilter
    {
        public static Result GetStationsByTypedValue(string typedValue)
        {
            var stations = GetFilterResults(typedValue);
            var result = GetResultBasedOnFilterResults(stations);
            return result;
        }

        private static List<FilterResult> GetFilterResults(string typedValue)
        {
            var stations = new List<FilterResult>();
            if (!string.IsNullOrEmpty(typedValue))
            {
                stations = DatabaseSimulator.GetStations()
                .Where(st => st.Name.StartsWith(typedValue, StringComparison.OrdinalIgnoreCase))
                .Select(st => new FilterResult(st, st.Name.Substring(typedValue.Length))).ToList();
            }

            return stations;
        }

        private static Result GetResultBasedOnFilterResults(List<FilterResult> filterResults)
        {
            var result = new Result();
            if (filterResults.Count > 0)
            {
                foreach (var station in filterResults)
                {
                    result.Stations.Add(station.Station);
                    var selectedChar = GetNextCharacter(station.PartialName);
                    if (!result.NextCharacteres.Any(r => r == selectedChar))
                    {
                        result.NextCharacteres.Add(selectedChar);
                    }
                }
            }

            return result;
        }

        private static char GetNextCharacter(string subName)
        {
            return subName.FirstOrDefault();
        }

    }
}
