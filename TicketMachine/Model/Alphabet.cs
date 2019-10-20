using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketMachine.Interfaces;

namespace TicketMachine.Model
{
    public class Alphabet : IAlphabet
    {
        public IEnumerable<char> Characteres { get; set; }

        public Alphabet(IEnumerable<char> characteres)
        {
            this.Characteres = characteres;
        }

    }
}
