using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProjetoAsp.net.Models;

namespace ProjetoAsp.net.Controllers
{
    public class PacienteControllers
    {
        protected BancoConsultaContainer contexto = new BancoConsultaContainer();

        public void Adicionar(Paciente paciente)
        {
            if (paciente != null)
            {
                contexto.Consultas.Add(paciente);
                contexto.SaveChanges();
            }
        }

        public List<Paciente> ListarFuturas()
        {
            return contexto.Pacientes.Where(c => c.Ativo == true).ToList();
        }

        public List<Paciente> ListarRealizadas()
        {
            return contexto.Pacientes.Where(c => c.Ativo == false).ToList();
        }

        public Paciente BuscarPaciente(int id)
        {
            return contexto.Pacientes.Find(id);
        }

        public void Excluir(Paciente paciente)
        {
            paciente.Ativo = false;
   
            contexto.Entry(paciente).State = System.Data.Entity.EntityState.Modified;
            contexto.SaveChanges();
        }

        public void Editar(Paciente paciente)
        {
            contexto.Entry(paciente).State = System.Data.Entity.EntityState.Modified;
            contexto.SaveChanges();
        }
    }
}