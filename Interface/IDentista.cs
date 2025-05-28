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
    public interface IDentista
    {
        [OperationContract]
        void cadastrar(Dentista obj);

        [OperationContract]
        Dentista buscar(int id);

        [OperationContract]
        List<Dentista> listar();

        [OperationContract]
        void editar(Dentista objNovo);

        [OperationContract]
        void excluir(int id);
    }
}
