using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketMachine.Interfaces
{
    public interface IAlphabet{
        IEnumerable<char> Characteres { get; set; }
    }
}
