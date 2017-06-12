using Aula1206.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Aula1206.Controllers
{
    public class CategoriasController : Controller
    {
        // GET: Categorias
        public ActionResult Index()
        {
           // List<string> categorias = new List<string>();

            //categorias.Add("Carros");
            //categorias.Add("Motos");
            //categorias.Add("Barcos");
            //categorias.Add("Aviões");
            //categorias.Add("Caminhões");
            List<Categoria> categorias = new List<Categoria>();

            categorias.Add(new Categoria() { Nome = "Carros" , Descricao="Lancer"});
            categorias.Add(new Categoria() { Nome = "Motos", Descricao = "Pop 100" });
            categorias.Add(new Categoria() { Nome = "Barcos", Descricao = "Lancha" });
            categorias.Add(new Categoria() { Nome = "Aviões", Descricao = "Jato" });
            categorias.Add(new Categoria() { Nome = "Caminhões", Descricao = "Volvo" });
            

            ViewBag.ListaCategorias = categorias;

            return View(categorias);
        }

        //GET 
        public ActionResult Create()
        {
            return View();
        }

       [HttpPost]
        public ActionResult Create(Categoria categorias)
        {
            return View(categorias);
        }
    }
}