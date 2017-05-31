using ProjetoAsp.net.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoAsp.net.Controllers
{
    public class ConsultaControllers
    {
        protected BancoConsultaContainer contexto = new BancoConsultaContainer();

        public void Adicionar(Consulta consulta)
        {
            if (consulta != null)
            {
                contexto.Consultas.Add(consulta);
                contexto.SaveChanges();
            }
        }

        public List<Consulta> ListarFuturas()
        {
            return contexto.Consultas.Where(c => c.Ativo == true).ToList();
        }

        public List<Consulta> ListarRealizadas()
        {
            return contexto.Consultas.Where(c => c.Ativo == false).ToList();
        }

        public Consulta BuscarConsulta(int id)
        {
            return contexto.Consultas.Find(id);
        }

        public void Excluir (Consulta consulta)
        {
            consulta.Ativo = false;

            contexto.Entry(consulta).State = System.Data.Entity.EntityState.Modified;
            contexto.SaveChanges();
        }

        public void Editar (Consulta consulta)
        {
            contexto.Entry(consulta).State = System.Data.Entity.EntityState.Modified;
            contexto.SaveChanges();
        }

    }
}       
