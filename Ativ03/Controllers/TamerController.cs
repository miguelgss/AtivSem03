using Ativ03.DAO;
using Ativ03.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ativ03.Controllers
{
    public class TamerController : Controller
    {
        private readonly TamerDAO tamerDAO;
        // GET: Tamer

        public TamerController()
        {
            tamerDAO = new TamerDAO();
        }
        public ActionResult Index() // Imprime uma lista com todos os Tamer do banco de dados
        {
            var TamerList = tamerDAO.Search();
            return View(TamerList);
        }

        public ActionResult Create() // Redireciona para a pagina de criação
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Tamer Tamer) // Recebe um objeto para incluí-lo no banco
        {
            if (ModelState.IsValid)
            {
                tamerDAO.CreateOrUpdate(Tamer);
                return RedirectToAction("Index");
            }
            return View(Tamer);
        }

        public ActionResult Edit(int id) // PESQUISA e redireciona para a pagina de edição de acordo com o ID
        {
            var Tamer = tamerDAO.SearchByID(id);

            if (Tamer == null) // Caso o Tamer não exista...
            {
                return HttpNotFound();
            }
            return View(Tamer);
        }

        [HttpPost]
        public ActionResult Edit(Tamer Tamer) // Ao receber um objeto, permite editá-lo
        {
            if (ModelState.IsValid)
            {
                tamerDAO.CreateOrUpdate(Tamer);
                return RedirectToAction("Index");
            }
            return View(Tamer);
        }

        public ActionResult Delete(int id) // PESQUISA e redireciona para a pagina de exclusão de acordo com o ID
        {
            var Tamer = tamerDAO.SearchByID(id);

            if (Tamer == null) // Caso o Tamer não exista...
            {
                return HttpNotFound();
            }
            return View(Tamer);
        }

        [HttpPost, ActionName("Delete")] // Action name permite fazer uma espécie de "sobreposição" da função acima.
        public ActionResult ReallyDelete(int id) // Ao receber um id, permite excluí-lo
        {
            var Tamer = tamerDAO.SearchByID(id);
            tamerDAO.Delete(Tamer);
            return RedirectToAction("Index");
        }
    }
}