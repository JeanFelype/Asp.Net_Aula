using Aula2405_EF_MF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Aula2405_EF_MF.Controllers;

namespace Aula2405_EF_MF.Views.Categorias
{
    public partial class Lista : BasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CategoriasController ctrl = new CategoriasController();
            List<Categoria> lista = ctrl.Listar();
            gvCategorias.DataSource = lista.OrderBy(c => c.Nome);
            gvCategorias.DataBind();

            gvCategoriasExcluidas.DataSource = ctrl.ListarInativo();
            gvCategoriasExcluidas.DataBind();
        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            if (!txtNome.Text.Equals(""))
            {
                Categoria C = new Categoria();
                C.Nome = txtNome.Text;
                C.Descricao = txtDescricao.Text;
                C.Ativo = true;
                CategoriasController ctrl = new CategoriasController();
                ctrl.Adicionar(C);
            }
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            txtDescricao.Text = string.Empty;
            txtNome.Text = string.Empty;
        }
    }
}