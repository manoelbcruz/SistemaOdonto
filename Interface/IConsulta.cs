using Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    [ServiceContract]
    public interface IConsulta
    {
        [OperationContract]
        void cadastrar(Consulta obj);

        [OperationContract(Name = "BuscarPorId")]
        Consulta buscar(int id);

        [OperationContract(Name = "BuscarPorDentistaData")]
        List<Consulta> buscar(Dentista dentista, DateTime data);

        [OperationContract(Name = "BuscarPorDentista")]
        IQueryable<Consulta> buscar(Dentista dentista);

        [OperationContract]
        void editar(Consulta objNovo);

        [OperationContract]
        void excluir(int id);
    }
}
