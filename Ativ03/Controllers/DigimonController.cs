using Ativ03.DAO;
using Ativ03.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ativ03.Controllers
{
    public class DigimonController : Controller
    {
        private DigimonDAO digimonDAO;
        // GET: Digimon

        public DigimonController()
        {
            digimonDAO = new DigimonDAO();
        }

        public ActionResult Index() // Imprime uma lista com todos os Digimon do banco de dados
        {
            var digimonList = digimonDAO.Search();
            return View(digimonList);
        }

        public ActionResult Create() // Redireciona para a pagina de criação
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Digimon digimon) // Recebe um objeto para incluí-lo no banco
        {
            if (ModelState.IsValid)
            {
                digimonDAO.CreateOrUpdate(digimon);
                return RedirectToAction("Index");
            }
            return View(digimon);
        }

        public ActionResult Edit(int id) // PESQUISA e redireciona para a pagina de edição de acordo com o ID
        {
            var digimon = digimonDAO.SearchByID(id);

            if (digimon == null) // Caso o digimon não exista...
            {
                return HttpNotFound();
            }
            return View();
        }

        [HttpPost]
        public ActionResult Edit(Digimon digimon) // Ao receber um objeto, permite editá-lo
        {
            if (ModelState.IsValid)
            {
                digimonDAO.CreateOrUpdate(digimon);
                return RedirectToAction("Index");
            }
            return View(digimon);
        }

        public ActionResult Delete(int id) // PESQUISA e redireciona para a pagina de exclusão de acordo com o ID
        {
            var digimon = digimonDAO.SearchByID(id);

            if (digimon == null) // Caso o digimon não exista...
            {
                return HttpNotFound();
            }
            return View();
        }

        [HttpDelete, ActionName("Delete")]
        public ActionResult ReallyDelete(int id) // Ao receber um id, permite excluí-lo
        {
            var digimon = digimonDAO.SearchByID(id);
            digimonDAO.Delete(digimon);
            return RedirectToAction("Index");
        }

    }
}