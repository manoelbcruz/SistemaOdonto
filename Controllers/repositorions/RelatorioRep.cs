using Controllers.context;
using Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers.repositorions
{
    public class RelatorioRep
    {
        public void salvar(Relatorio obj)
        {
            using (var ctx = new SistemaContext())
            {
                ctx.Relatorios.Add(obj);
                ctx.SaveChanges();
            }
        }
    }
}
