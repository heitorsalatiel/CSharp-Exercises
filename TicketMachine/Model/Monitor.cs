using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketMachine.Interfaces;

namespace TicketMachine.Model
{
    public class Monitor : IMonitor
    {
        public Monitor()
        {

        }

        public string GenerateView(IEnumerable<string> Elements)
        {
            var sb = new StringBuilder();
            foreach (var el in Elements)
            {
                sb.AppendLine(el);
            }

            return sb.ToString();
        }
    }
}
