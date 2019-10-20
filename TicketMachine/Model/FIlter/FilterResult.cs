using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketMachine.Model
{
    public class FilterResult
    {
        public Station Station { get; set; }
        public string PartialName { get; set; }

        public FilterResult()
        {

        }
        public FilterResult(Station station, string partialName)
        {
            Station = station;
            PartialName = partialName;
        }
    }
}
