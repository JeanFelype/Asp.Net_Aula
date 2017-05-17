using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Aula1705
{
    public partial class Calculadora : System.Web.UI.Page
    {
        double n1
        {
            get
            {
                return n1 = Convert.ToDouble(ViewState["N1"]);
            }
            set
            {
                ViewState["N1"] = value;
            }
               
        }
        double n2
        {
            get
            {
                return n2 = Convert.ToDouble(ViewState["N2"]);
            }
            set
            {
                ViewState["N2"] = value;
            }
        }
        double soma { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                n1 = 0;
                n2 = 0;
            }
                
        }

        protected void btnSomar_Click(object sender, EventArgs e)
        {
            n1 = float.Parse(txtNumero1.Text);
            n2 = float.Parse(txtNumero2.Text);

            soma = n1 + n2;
            txtResultado.Text = soma.ToString();
        }

        protected void btnIgual_Click(object sender, EventArgs e)
        {
            Session.Add("N1", n1);
            Session.Add("N2", n2);
            Response.Redirect("~/CalculadoraResultado.aspx");
        }
    }
}