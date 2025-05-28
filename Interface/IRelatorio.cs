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
    public interface IRelatorio
    {
        [OperationContract]
        void salvar(Relatorio obj);
    }
}
