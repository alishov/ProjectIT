using Reservation.Controlers;
using Reservation.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reservation
{
    public class Startup
    {
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.Run(new FormInsertIntoCountry());

            //ConsoleControler controler = new ConsoleControler();


        }
    }
}
