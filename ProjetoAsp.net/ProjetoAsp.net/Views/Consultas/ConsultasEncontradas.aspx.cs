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
    public partial class ConsultasEncontradas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ConsultaControllers cc = new ConsultaControllers();
            List<Consulta> lista = cc.ListarFuturas();
            gvConsultaAtivas.DataSource = lista.OrderBy(c => c.Nome);
            gvConsultaAtivas.DataBind();

            gvConsultaInativas.DataSource = cc.ListarRealizadas();
            gvConsultaInativas.DataBind();
        }
    }
}