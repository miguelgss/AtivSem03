using Ativ03.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ativ03.DAO
{
    public class TamerDAO
    {

        private readonly DigiContext BD;

        public TamerDAO()
        {
            BD = new DigiContext();
        }

        public void CreateOrUpdate(Tamer Tamer)
        {
            if(Tamer.Id > 0) // Caso já exista...UPDATE!
            {
                var digiUpdate = BD.Tamers.First(x => x.Id == Tamer.Id);
                digiUpdate.Name = Tamer.Name;
                digiUpdate.Age = Tamer.Age;
                digiUpdate.Nationality = Tamer.Nationality;

            }
            else // Caso não exista...CREATE!
            {
                BD.Tamers.Add(Tamer);
            }
            BD.SaveChanges();
        }

        public Tamer SearchByID(int id)
        {
            var TamerResearched = BD.Tamers.Where(x => x.Id == id).FirstOrDefault();
            return TamerResearched;
        }

        public IEnumerable<Tamer> Search()
        {
            return BD.Tamers; // Retorna os dados do BD de forma bem simples
        }

        public void Delete(Tamer Tamer)
        {
            if(Tamer.Id > 0) // Caso o Tamer exista...
            {
                var TamerDeleted = BD.Tamers.FirstOrDefault(x => x.Id == Tamer.Id);
                BD.Tamers.Remove(TamerDeleted);
                BD.SaveChanges();
            }
        }
    }
}