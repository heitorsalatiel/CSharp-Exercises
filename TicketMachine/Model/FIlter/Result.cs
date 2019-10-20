using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketMachine.Model
{
    public class Result
    {
        private List<Station> _stations;
        public List<Station> Stations
        {
            get
            {
                if (this._stations == null)
                {
                    this._stations = new List<Station>();
                }
                return this._stations;
            }
            set { this._stations = value; }
        }

        private List<char> _nextCharacteres;
        public List<char> NextCharacteres
        {
            get
            {
                if (this._nextCharacteres == null)
                {
                    this._nextCharacteres = new List<char>();
                }
                return this._nextCharacteres;
            }
            set { this._nextCharacteres = value; }
        }
    }
}
