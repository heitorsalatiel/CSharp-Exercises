using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketMachine.Interfaces;
using TicketMachine.Model;

namespace TicketMachine.Builders
{
    public class MonitorBuilder : MachineBuilder
    {
        public MonitorBuilder(Machine machine){
            this.Machine = machine;
        }

        public MonitorBuilder SetMonitor(IMonitor monitor)
        {
            this.Machine.Monitor = monitor;
            return this;
        }
    }
}
