using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ASP_NET.Models;

namespace ASP_NET.Controllers
{
    public class CategoriaController : Controller
    {
        public IActionResult Index()
        {
            var categoria = new Categoria();
            
            categoria.Id = 001;
            categoria.Nombre = "Serigrafía";
            categoria.Activo = true;
            categoria.Seleccion = false;

            return View(categoria);
        }

        public IActionResult MultiCategoria()
        {
            var listCategoria = new List<Categoria>()
            {
                new Categoria{Id=1, Nombre="Serigrafía", Activo=true, Seleccion=true},
                new Categoria{Id=2, Nombre="Imprenta general", Activo=true, Seleccion=true},
                new Categoria{Id=3, Nombre="Bordados", Activo=true, Seleccion=true},
                new Categoria{Id=4, Nombre="Gran formato", Activo=true, Seleccion=true},
            };
            return View(listCategoria);
        }

    }
}