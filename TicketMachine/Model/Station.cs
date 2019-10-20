using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketMachine.Model
{
    public class Station
    {
        public string Name { get; set; }

        public Station(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine(this.Name);
            sb.Append("---------------------------");
            return sb.ToString();
        }
    }
}
