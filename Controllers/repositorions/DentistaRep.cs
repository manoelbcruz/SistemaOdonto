using Controllers.context;
using Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Controllers.repositorions
{
    public class DentistaRep
    {
        public void cadastrar (Dentista obj)
        {
            using (var ctx = new SistemaContext())
            {
                ctx.Dentistas.Add(obj);
                ctx.SaveChanges();
            }    
        }
        public Dentista buscar (int id)
        {
            Dentista obj = new Dentista();
            using(var ctx = new SistemaContext())
            {
                obj = ctx.Dentistas.Find(id);
            }
            return obj;
        }
        public List<Dentista> listar()
        {
            using (var ctx = new SistemaContext())
            {
                var dentistas = (from obj in ctx.Dentistas select obj).OrderBy(x => x.Name).ToList();
                return dentistas;
            }
        }
        public void excluir(int id)
        {
            using (var ctx = new SistemaContext())
            {
                Dentista obj = ctx.Dentistas.Find(id);
                ctx.Dentistas.Remove(obj);
                ctx.SaveChanges();
            }
        }
        public void editar(Dentista objNovo)
        {
            using(var ctx = new SistemaContext())
            {
                Dentista objAnt = ctx.Dentistas.Find(objNovo.Id);
                objAnt.Name = objNovo.Name;
                objAnt.Celular = objNovo.Celular;
                objAnt.Telefone = objNovo.Telefone;
                objAnt.Email = objNovo.Email;
                objAnt.CRO = objNovo.CRO;
                ctx.SaveChanges();
            }
        }
    }
}
