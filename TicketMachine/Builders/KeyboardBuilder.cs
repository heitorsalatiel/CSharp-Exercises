using TicketMachine.Interfaces;
using TicketMachine.Model;

namespace TicketMachine.Builders
{
    public class KeyboardBuilder : MachineBuilder
    {
        public KeyboardBuilder(Machine machine) {
            this.Machine = machine;
        }

        public KeyboardBuilder SetKeyboard(IKeyboard keyboard)
        {
            this.Machine.Keyboard = keyboard;
            return this;
        } 
    }
}
