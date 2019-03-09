using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservation.Controlers
{
    public class Find
    {
        private static ReservationContext context = new ReservationContext();

        public Country FindCountry(string coutryName)
        {
            Country find = context.Countries
                .FirstOrDefault(x => x.Name == coutryName);
            return find;
        }

        public Town FindTown(string countryName, string townName)
        {
            Country findCoutry = FindCountry(countryName);
            if (findCoutry == null)
            {
                return null;
            }
            else
            {
                Town find = context.Towns
                    .Where(x => x.Name == townName && x.Country.Name == countryName)
                    .FirstOrDefault();
                return find;
            }
        }
    }
}
