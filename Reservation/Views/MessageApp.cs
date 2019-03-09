using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservation.Views
{
    public class MessageApp
    {
        public string MessageInsertCoutryTrue(string countryName)
        {
            string message = $"{countryName} е добавена успешно в таблцита с държави!";
            return message;
        }

        public string MessageInsertCoutryFalse(string countryName)
        {
            string message = $"{countryName} вече съществува в таблцита с държави!";
            return message;
        }

        public string MessageInsertTownTrue(string countryName, string townName)
        {
            string message = $"В държавата '{countryName}' е добавен нов град с име '{townName}'";
            return message;
        }

        public string MessageInsertTownFalse(string countryName,string townName)
        {
            string message = $"В '{countryName}' вече съществува град с име '{townName}'!";
            return message;
        }
    }
}
