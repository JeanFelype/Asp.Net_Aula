using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProjetoAsp.net.Controllers;
using ProjetoAsp.net.Models;

namespace ProjetoAsp.net.Views.Consultas
{
    public partial class ListaConsultas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ConsultaControllers cc = new ConsultaControllers();
        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            if(!txtData.Text.Equals("") && !txtNome.Text.Equals("") && !txtPreco.Text.Equals(""))
            {
                Consulta C = new Consulta();
                C.Nome = txtNome.Text;
                C.Preco = decimal.Parse(txtPreco.Text);
                C.Data = txtData.Text;
                C.Ativo = true;
                ConsultaControllers cc = new ConsultaControllers();
                cc.Adicionar(C);
            }
        }

        protected void btnMostrar_Click(object sender, EventArgs e)
        {
            
        }
    }
}