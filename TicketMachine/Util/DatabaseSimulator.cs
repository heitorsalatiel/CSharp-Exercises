using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketMachine.Model;

namespace TicketMachine.Util
{
    public static class DatabaseSimulator
    {
        private static List<Station> Stations = new List<Station> {
            new Station("DARTFORD"),
            new Station("DARTMOUTH"),
            new Station("TOWER HILL"),
            new Station("DERBY"),
            new Station("LIVERPOOL"),
            new Station("LIVERPOOL LIME STREET"),
            new Station("PADDINGTON"),
            new Station("EUSTON"),
            new Station("LONDON BRIDGE"),
            new Station("VICTORIA")
        };

        public static List<Station> GetStations() =>  Stations;
    }
}
