using Entidade;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Controllers.map
{
    internal class RelatorioMap : EntityTypeConfiguration<Relatorio>
    {
        public RelatorioMap()
        {
            this.HasKey(d => d.Name);
            this.Property(d => d.Name).HasColumnName("Nome_Relatorio");
            this.Property(d => d.Mensagem).HasColumnName("Mensagem_Relatorio");
            this.Property(d => d.Telefone).HasColumnName("Telefone_Relatorio");
            this.Property(d => d.Endereco).HasColumnName("Endereco_Relatorio");
        }
        
    }
}
