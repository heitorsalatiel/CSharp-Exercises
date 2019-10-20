using System.Collections;
using System.Collections.Generic;
using System.Text;
using TicketMachine.Interfaces;

namespace TicketMachine.Model
{
    public class Machine : IMachine
    {
        public IMonitor Monitor { get; set; }
        public IKeyboard Keyboard { get; set; }
        private Dictionary<string,object> _additions { get; set; }
        public Dictionary<string,object> Additions {
            get { 
                if(this._additions == null)
                {
                    this._additions = new Dictionary<string,object>();
                }
                return this._additions;
            }
            set
            {
                this._additions = value;
            } 
        }

        public Machine(IMonitor monitor ,IKeyboard keyboard)
        {
            this.Monitor = monitor;
            this.Keyboard = keyboard;
        }

        public void SetAddition(string key, object value)
        {
            if(this.Additions.ContainsKey(key))
            {
                this.Additions[key] = value;
            }
            else
            {
                this.Additions.Add(key, value);
            }
        }

        public Machine()
        {
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            foreach(var item in this._additions)
            {
                var obj = item.Value as IEnumerable;
                if(obj != null)
                {
                    foreach(var element in obj)
                    {
                        sb.AppendLine(element.ToString());
                    }
                }
            }
            var view = new List<string> { this.Keyboard.ToString(), sb.ToString() };
            return this.Monitor.GenerateView(view);
        }
    }
}
