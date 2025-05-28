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
    public interface IPaciente
    {
        [OperationContract]
        void cadastrar(Paciente obj);

        [OperationContract]
        Paciente buscar(int id);

        [OperationContract]
        List<Paciente> listar();

        [OperationContract]
        void editar(Paciente objNovo);

        [OperationContract]
        void excluir(int id);
    }
}
