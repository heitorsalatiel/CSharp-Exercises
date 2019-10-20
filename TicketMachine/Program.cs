using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketMachine.Builders;
using TicketMachine.Model;
namespace TicketMachine
{
    class Program
    {
        private const string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ ";
        static void Main(string[] args)
        {
            var typedValue = string.Empty;
            var machineBuilder = new MachineBuilder();
            var kAlphabet = new Alphabet(alphabet);
            var keyboard = new Keyboard(kAlphabet);
            var monitor = new Monitor();
            Machine machine =  machineBuilder.Monitor.SetMonitor(monitor).Keyboard.SetKeyboard(keyboard);

            while (true)
            {
                var stations = StationFilter.GetStationsByTypedValue(typedValue);
                machine.SetAddition("station",stations.Stations);
                keyboard.Filter(string.Join(string.Empty,stations.NextCharacteres));

                Console.WriteLine("TICKET MACHINE");
                Console.WriteLine();
                Console.WriteLine(machine);
                Console.WriteLine("Enter the Station Name : ");

                typedValue = Console.ReadLine();
                keyboard.Alphabet = new Alphabet(alphabet);

                Console.WriteLine(typedValue);
                Console.Clear();
            }

        }
    }
}
