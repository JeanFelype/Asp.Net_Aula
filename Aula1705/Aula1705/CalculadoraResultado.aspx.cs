using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Aula1705
{
    public partial class CalculadoraResultado : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            double N1Session = Convert.ToDouble(Session["N1"]);
            double N2Session = Convert.ToDouble(Session["N2"]);
            double resul = N1Session + N2Session;
            txtN1.Text = N1Session.ToString();
            txtN2.Text = N2Session.ToString();
            txtResultado1.Text = resul.ToString();
            //txtN3.Text = N1Session.ToString();
        }
    }
}