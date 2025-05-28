using Controllers.repositorions;
using Entidade;
using Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfService
{
    public class consultaService : IConsulta
    {
        private ConsultaRep rep = new ConsultaRep();

        public void cadastrar(Consulta obj)
        {
            rep.cadastrar(obj);
        }
        public Consulta buscar(int id)
        {
            return rep.buscar(id);
        }
        public IQueryable<Consulta> buscar(Dentista dentista)
        {
            return rep.buscar(dentista);
        }
        public List<Consulta> buscar(Dentista dentista, DateTime data)
        {
            return rep.buscar(dentista, data);
        }
        public void editar(Consulta objNovo)
        {
            rep.editar(objNovo);
        }
        public void excluir(int id)
        {
            rep.excluir(id);
        }
    }
}
