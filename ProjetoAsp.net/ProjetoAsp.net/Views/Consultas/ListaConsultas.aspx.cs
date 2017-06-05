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

            if(!IsPostBack)
            {
                PacienteControllers pc = new PacienteControllers();
                ddlPacientes.DataSource = pc.ListarFuturas();
                ddlPacientes.DataBind();
            }
        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            if(!txtData.Text.Equals("") && !txtNome.Text.Equals("") && !txtPreco.Text.Equals(""))
            {
                Consulta C = new Consulta();
                C.Nome = txtNome.Text;
                C.Preco = decimal.Parse(txtPreco.Text);
                C.Data = txtData.Text;
                C.PacienteId = int.Parse(ddlPacientes.SelectedValue);
                C.Ativo = true;
                ConsultaControllers cc = new ConsultaControllers();
                cc.Adicionar(C);
            }
        }

        protected void btnMostrar_Click(object sender, EventArgs e)
        {
            Response.Redirect("ConsultasEncontradas.aspx");
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            int idConsulta = int.Parse(txtID.Text);
            ConsultaControllers cc = new ConsultaControllers();
            Consulta C = cc.BuscarConsulta(idConsulta);

            if(C != null)
            {
                txtNomeEncontrado.Text = C.Nome;
                txtPrecoEncontrado.Text = C.Preco.ToString();
                txtDataEncontrada.Text = C.Data;
                ddlPacientes.SelectedValue = C.Id.ToString();
            }
        }

        protected void btnExcluir_Click(object sender, EventArgs e)
        {
            Consulta C = new Consulta();
            ConsultaControllers cc = new ConsultaControllers();
            cc.Excluir(C);
        }
    }
}