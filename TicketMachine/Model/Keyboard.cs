using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketMachine.Interfaces;
using TicketMachine.Util;

namespace TicketMachine.Model
{
    public class Keyboard : IKeyboard
    {
        public IAlphabet Alphabet { get; set; }


        public Keyboard(IAlphabet characteres)
        {
            Alphabet = characteres;
        }

        public void Filter(IEnumerable<char> chars)
        {
            if(chars.Count() > 0)
            {
                this.Alphabet.Characteres = this.Alphabet.Characteres.Where(c => chars.Contains(c)).ToList();
            }
        }

        private string impToString()
        {
            var sb = new StringBuilder();
            var characteres = this.Alphabet.Characteres.ToTwoDimensionalCollection(5);
            foreach (var rows in characteres)
            {
                foreach (var col in rows)
                {
                    sb.Append($"{col} | ");
                }
                sb.AppendLine();
            }
            return sb.ToString();
        }
        public override string ToString()
        {
            return this.impToString();
        }
    }
}
