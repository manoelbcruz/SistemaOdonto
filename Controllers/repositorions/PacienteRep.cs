using Controllers.context;
using Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers.repositorions
{
    public class PacienteRep
    {
        public void cadastrar(Paciente obj)
        {
            using (var ctx = new SistemaContext())
            {
                ctx.Pacientes.Add(obj);
                ctx.SaveChanges();
            }
        }
        public Paciente buscar(int id)
        {
            Paciente obj = new Paciente();
            using (var ctx = new SistemaContext())
            {
                obj = ctx.Pacientes.Find(id);
            }
            return obj;
        }
        public List<Paciente> listar()
        {
            using (var ctx = new SistemaContext())
            {
                var pacientes = (from obj in ctx.Pacientes select obj).OrderBy(x => x.Name).ToList();
                return pacientes;
            }
        }
        public void excluir(int id)
        {
            using (var ctx = new SistemaContext())
            {
                Paciente obj = ctx.Pacientes.Find(id);
                ctx.Pacientes.Remove(obj);
                ctx.SaveChanges();
            }
        }
        public void editar(Paciente objNovo)
        {
            using (var ctx = new SistemaContext())
            {
                Paciente objAnt = ctx.Pacientes.Find(objNovo.Id);
                objAnt.Name = objNovo.Name;
                objAnt.Celular = objNovo.Celular;
                objAnt.Telefone = objNovo.Telefone;
                objAnt.Email = objNovo.Email;
                objAnt.CEP = objNovo.CEP;
                objAnt.Endereco = objNovo.Endereco;
                objAnt.Nascimento = objNovo.Nascimento;
                objAnt.Complemento = objNovo.Complemento;
                objAnt.Sexo = objNovo.Sexo;
                ctx.SaveChanges();
            }
        }
    }
}
