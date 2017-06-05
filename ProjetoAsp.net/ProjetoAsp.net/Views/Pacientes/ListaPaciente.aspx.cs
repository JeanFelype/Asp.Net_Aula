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
                PacienteControllers pc = new PacienteControllers();
                pc.Adicionar(P);
            }
        }
    }
}