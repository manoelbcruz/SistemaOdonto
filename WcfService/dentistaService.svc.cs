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
    // OBSERVAÇÃO: Você pode usar o comando "Renomear" no menu "Refatorar" para alterar o nome da classe "dentistaService" no arquivo de código, svc e configuração ao mesmo tempo.
    // OBSERVAÇÃO: Para iniciar o cliente de teste do WCF para testar esse serviço, selecione dentistaService.svc ou dentistaService.svc.cs no Gerenciador de Soluções e inicie a depuração.
    public class dentistaService : IDentista
    {
        private DentistaRep rep = new DentistaRep();

        public void cadastrar(Dentista obj)
        {
            rep.cadastrar(obj);
        }
        public Dentista buscar(int id)
        {
            return rep.buscar(id);
        }
        public List<Dentista> listar()
        {
            return rep.listar();
        }
        public void editar(Dentista objNovo)
        {
            rep.editar(objNovo);
        }
        public void excluir(int id)
        {
            rep.excluir(id);
        }
    }
}
