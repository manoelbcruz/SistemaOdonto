using Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Interface;
using Controllers.repositorions;

namespace WcfService
{
    public class pacienteService : IPaciente
    {
        private PacienteRep rep = new PacienteRep();

        public void cadastrar(Paciente obj)
        {
            rep.cadastrar(obj);
        }
        public Paciente buscar(int id)
        {
            return rep.buscar(id);
        }
        public List<Paciente> listar()
        {
            return rep.listar();
        }
        public void editar(Paciente objNovo)
        {
            rep.editar(objNovo);
        }
        public void excluir(int id)
        {
            rep.excluir(id);
        }
    }
}
