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
    }
}
