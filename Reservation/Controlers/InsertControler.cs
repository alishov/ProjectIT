using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservation.Controlers
{
    public class InsertControler
    {
        private static ReservationContext context = new ReservationContext();
        private static Find find = new Find();

        public bool InsertIntoCoutries(string coutryName)
        {
            if (find.FindCountry(coutryName)==null)
            {
                context.Countries.Add(
                    new Country() { Name = coutryName });
                context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool InsertIntoTowns(string townName, string countryName)
        {
            Town findTown = find.FindTown(countryName, townName);
            if (findTown==null)
            {
                InsertIntoCoutries(countryName);
                Town newTown = new Town()
                {
                    Name = townName,
                    CountryId = find.FindCountry(countryName).Id
                };
                context.Towns.Add(newTown);
                context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
