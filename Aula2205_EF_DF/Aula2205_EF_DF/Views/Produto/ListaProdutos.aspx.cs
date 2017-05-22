using Aula2205_EF_DF.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Aula2205_EF_DF.Views.Produto
{
    public partial class ListaProdutos : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            strConnLojaEntities contexto = new strConnLojaEntities();

            gvwProdutos.DataSource = contexto.Produtoes.ToList();
            gvwProdutos.DataBind();
        }
    }
}