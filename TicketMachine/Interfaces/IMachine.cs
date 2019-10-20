using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketMachine.Interfaces
{
    public interface IMachine{
        public IMonitor Monitor { get; set; }
        public IKeyboard Keyboard { get; set; }
    }
}
