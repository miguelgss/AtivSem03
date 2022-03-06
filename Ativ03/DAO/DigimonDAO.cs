using Ativ03.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ativ03.DAO
{
    public class DigimonDAO
    {

        private readonly DigiContext BD;

        public DigimonDAO()
        {
            BD = new DigiContext();
        }

        public void CreateOrUpdate(Digimon digimon)
        {
            if(digimon.Id > 0) // Caso já exista...UPDATE!
            {
                var digiUpdate = BD.Digimons.First(x => x.Id == digimon.Id);
                digiUpdate.Name = digimon.Name;
                digiUpdate.Stage = digimon.Stage;
                digiUpdate.Type = digimon.Type;

            }
            else // Caso não exista...CREATE!
            {
                BD.Digimons.Add(digimon);
            }
            BD.SaveChanges();
        }

        public Digimon SearchByID(int id)
        {
            var digimonResearched = BD.Digimons.Where(x => x.Id == id).FirstOrDefault();
            return digimonResearched;
        }

        public IEnumerable<Digimon> Search()
        {
            return BD.Digimons; // Retorna os dados do BD de forma bem simples
        }

        public void Delete(Digimon digimon)
        {
            if(digimon.Id > 0) // Caso o digimon exista...
            {
                var digimonDeleted = BD.Digimons.FirstOrDefault(x => x.Id == digimon.Id);
                BD.Digimons.Remove(digimonDeleted);
                BD.SaveChanges();
            }
        }
    }
}