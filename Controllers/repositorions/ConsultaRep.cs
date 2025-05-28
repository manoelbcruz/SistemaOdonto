using Controllers.context;
using Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers.repositorions
{
    public class ConsultaRep
    {
        public void cadastrar(Consulta obj)
        {
            using (var ctx = new SistemaContext())
            {
                ctx.Consultas.Add(obj);
                ctx.SaveChanges();
            }
        }
        public Consulta buscar(int id)
        {
            Consulta obj = new Consulta();
            using (var ctx = new SistemaContext())
            {
                obj = ctx.Consultas.Find(id);
            }
            return obj;
        }
        public IQueryable<Consulta> buscar(Dentista dentista)
        {
            var ctx = new SistemaContext();
            Paciente paciente = new Paciente();

            var consultas = ctx.Consultas.Where(c => c.IdDentista == dentista.Id);
            
            return consultas;
            
        }
        public List<Consulta> buscar(Dentista dentista, DateTime data)
        {
            var ctx = new SistemaContext();
            List<Consulta> consultas = new List<Consulta>();
            var queryConsultas = ctx.Consultas.Where(c => c.IdDentista ==  dentista.Id);
            foreach (var consulta in queryConsultas)
            {
                if(consulta.Data == data)
                {
                    consultas.Add(consulta);
                }
            }
            return consultas;
        }
        public void excluir(int id)
        {
            using (var ctx = new SistemaContext())
            {
                Consulta obj = ctx.Consultas.Find(id);
                ctx.Consultas.Remove(obj);
                ctx.SaveChanges();
            }
        }
        public void editar(Consulta objNovo)
        {
            using (var ctx = new SistemaContext())
            {
                Consulta objAnt = ctx.Consultas.Find(objNovo.IdConsulta);
                objAnt.IdDentista = objNovo.IdDentista;
                objAnt.IdPaciente = objNovo.IdPaciente;
                objAnt.Observacao = objNovo.Observacao;
                objAnt.Data = objNovo.Data;
                objAnt.Status = objNovo.Status;
                objAnt.HoraFim = objNovo.HoraFim;
                objAnt.HoraInicio = objNovo.HoraInicio;
                objAnt.HoraMarcada = objNovo.HoraMarcada;
                ctx.SaveChanges();
            }
        }
    }
}
