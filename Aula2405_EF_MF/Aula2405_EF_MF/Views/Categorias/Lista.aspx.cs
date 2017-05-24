using Aula2405_EF_MF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Aula2405_EF_MF.Views.Categorias
{
    public partial class Lista : BasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Categoria> categorias = contexto.Categorias.ToList();
        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            if (!txtNome.Text.Equals(""))
            {
                Categoria C = new Categoria();
                C.Nome = txtNome.Text;
                C.Descricao = txtDescricao.Text;
                contexto.Categorias.Add(C);
                contexto.SaveChanges();
            }
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            txtDescricao.Text = string.Empty;
            txtNome.Text = string.Empty;
        }
    }
}