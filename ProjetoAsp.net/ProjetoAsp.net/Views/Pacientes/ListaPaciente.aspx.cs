using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProjetoAsp.net.Models;
using ProjetoAsp.net.Controllers;

namespace ProjetoAsp.net.Views.Pacientes
{
    public partial class ListaPaciente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            if(!txtDataNasc.Text.Equals("") && !txtNomeP.Text.Equals(""))
            {
                Paciente P = new Paciente();
                P.Nome = txtNomeP.Text;
                P.DataNascimento = txtDataNasc.Text;
                P.Ativo = true;
                PacienteControllers pc = new PacienteControllers();
                pc.Adicionar(P);
            }
        }

        protected void btnMostrar_Click(object sender, EventArgs e)
        {
            Response.Redirect("PacientesEncontrados.aspx");
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            int idPaciente = int.Parse(txtIDP.Text);
            PacienteControllers pc = new PacienteControllers();
            Paciente P = pc.BuscarPaciente(idPaciente);

            if (P != null)
            {
                txtNomePEncontrado.Text = P.Nome;
                txtDataNascEncontrado.Text = P.DataNascimento;
            }
        }

        protected void btnExcluir_Click(object sender, EventArgs e)
        {
            int idPaciente = int.Parse(txtIDP.Text);
            PacienteControllers pc = new PacienteControllers();
            Paciente P = pc.BuscarPaciente(idPaciente);
            P.Ativo = false;
            pc.Excluir(P);
        }

        protected void btnEditar_Click(object sender, EventArgs e)
        {
            int idPaciente = int.Parse(txtIDP.Text);
            PacienteControllers pc = new PacienteControllers();
            Paciente P = pc.BuscarPaciente(idPaciente);
            P.Ativo = true;
            P.Nome = txtNomePEncontrado.Text;
            P.DataNascimento = txtDataNascEncontrado.Text;
            pc.Editar(P);
        }

        protected void btnConsulta_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/Consultas/ListaConsultas.aspx");
        }
    }
}