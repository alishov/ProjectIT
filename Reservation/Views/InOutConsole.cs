using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservation.Views
{
    public class InOutConsole
    {
        public string ReadCoutryName()
        {
            Console.Write("Въведи име на държава: ");
            return Console.ReadLine();
        }
        public string ReadTownName()
        {
            Console.Write("Въведи име на град: ");
            return Console.ReadLine();
        }

        public void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
