using Aula2405_EF_MF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;

namespace Aula2405_EF_MF.Views
{
    public class BasePage : Page
    {
        protected BaseDadosContainer contexto = new BaseDadosContainer();
    }
}