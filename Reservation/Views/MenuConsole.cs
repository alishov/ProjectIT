﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservation.Views
{
    public class MenuConsole
    {
        public string MenuInsert()
        {
            Console.WriteLine("1 - Добави държава");
            Console.WriteLine("2 - Добави град");
            Console.Write("Избери команда: ");
            return Console.ReadLine();
        }
    }
}
