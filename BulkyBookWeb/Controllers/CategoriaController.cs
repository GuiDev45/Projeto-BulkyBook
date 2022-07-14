using BulkyBookWeb.Db;
using BulkyBookWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace BulkyBookWeb.Controllers
{
    public class CategoriaController : Controller
    {
        private readonly Contexto _db;

        public CategoriaController(Contexto db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Categoria> objCategoriaList = _db.Categorias;//Recupera todas as categorias da tabela
            return View(objCategoriaList);
        }

        //GET
        public IActionResult Criar()
        {
            return View();
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Criar(Categoria obj)
        {
            if (obj.Nome == obj.OrdemExibicao.ToString())
            {
                ModelState.AddModelError("nome", "The display order cannot exactly match the name");
            }
            if (ModelState.IsValid) 
            { 
                _db.Categorias.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }

        //GET
        public IActionResult Editar(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var categoriaFromDb = _db.Categorias.Find(id);
            //var categoriaFromDbFirst = _db.Categorias.FirstOrDefault(u => u.Id == id);
            //var categoriaFromDbSingle = _db.Categorias.SingleOrDefault(u => u.Id == id);

            if (categoriaFromDb == null)
            {
                return NotFound();
            }

            return View(categoriaFromDb);
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Editar(Categoria obj)
        {
            if (obj.Nome == obj.OrdemExibicao.ToString())
            {
                ModelState.AddModelError("nome", "The display order cannot exactly match the name");
            }
            if (ModelState.IsValid)
            {
                _db.Categorias.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }
    }
}
