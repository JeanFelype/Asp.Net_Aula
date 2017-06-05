using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProjetoAsp.net.Controllers;
using ProjetoAsp.net.Models;

namespace ProjetoAsp.net.Views.Pacientes
{
    public partial class PacientesEncontrados : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            PacienteControllers pc = new PacienteControllers();
            List<Paciente> lista = pc.ListarFuturas();
            gvPacientesAtivas.DataSource = lista.OrderBy(c => c.Nome);
            gvPacientesAtivas.DataBind();

            gvPacientesInativas.DataSource = pc.ListarRealizadas();
            gvPacientesInativas.DataBind();
        }
    }
}