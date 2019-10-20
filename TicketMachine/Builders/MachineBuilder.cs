using TicketMachine.Model;

namespace TicketMachine.Builders
{
    public class MachineBuilder
    {
        protected Machine Machine = new Machine();

        public KeyboardBuilder Keyboard => new KeyboardBuilder(this.Machine);

        public MonitorBuilder Monitor => new MonitorBuilder(this.Machine);


        public static implicit operator Machine(MachineBuilder builder)
        {   
            return builder.Machine;
        }

    }
}
