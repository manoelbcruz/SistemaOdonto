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
    public class relatorioService : IRelatorio
    {
        private RelatorioRep rep = new RelatorioRep();

        public void salvar(Relatorio obj)
        {
            rep.salvar(obj);
        }
    }
}
