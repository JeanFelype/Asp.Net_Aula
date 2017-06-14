using Aula1406.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Aula1406.Controllers
{
    public class CategoriasController : Controller
    {
        // GET: Categorias (Get = Carregamento da pagina)
        public ActionResult Index()
        {
            List<Categoria> categoiras = new List<Categoria>();
            //Retornar a Lista de objetos cadastrados
            return View(categoiras);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        //public ActionResult Create(string nome, string descricao, boll ativo)*/
        public ActionResult Create(Categoria categoria) /*(FormCollection campos) recuperar campo a campo, sem ter model*/
        {
            if (ModelState.IsValid)
            {
                //insert
            }
            return View(categoria);
        }

        //GET
        public ActionResult Edit(int? id)
        {
            //verificar se veio o id => BadRequest
            if (id == null)
            {
                //Erro - 400  
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            //Pesquisar na fonte de dados do objeto a editar
            //Categoria categoria = null;
            Categoria categoria = new Categoria()
            {
                CategoriaID = id.Value,
                Nome = "Carros",
                Descricao = "Lancer",
                Ativo = true
        };
            //se objeto não foi encontrado na fonte de dados
            if(categoria == null)
            {
                //Erro - 404
                return HttpNotFound();
            }
            return View(categoria);
        }

        [HttpPost]
        public ActionResult Edit(Categoria categorias)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    //Fazer update na fonte de dados
                    //Redirecionar
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            return View(categorias);
        }

        //GET

        public ActionResult Delete(int? id)
        {
            if(id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            //Categoria categoria = null;
            Categoria categoria = new Categoria()
            {
                CategoriaID = id.Value,
                Nome = "Carros",
                Descricao = "Lancer",
                Ativo = true
            };

            if (categoria == null)
            {
                return HttpNotFound();
            }
            return View(categoria);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            //pesquisar objeto por id

            //alterar status do objeto para deleted ou ativo para false

            TempData["Mesagem"] = "Categoria excluida com sucesso";
            return RedirectToAction("Index");
        }
    }
}