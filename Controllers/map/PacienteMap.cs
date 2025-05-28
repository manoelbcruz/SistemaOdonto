using Entidade;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers.map
{
    internal class PacienteMap : EntityTypeConfiguration<Paciente>
    {
        public PacienteMap() 
        {
            this.HasKey(d => d.Id);
            this.Property(d => d.Id).HasColumnName("Id_Paciente");
            this.Property(d => d.Name).HasColumnName("Nome_Paciente");
            this.Property(d => d.Email).HasColumnName("Email_Paciente");
            this.Property(d => d.Telefone).HasColumnName("Telefone_Paciente");
            this.Property(d => d.Celular).HasColumnName("Celular_Paciente");
            this.Property(d => d.CEP).HasColumnName("CEP_Paciente");
            this.Property(d => d.Endereco).HasColumnName("Endereço_Paciente");
            this.Property(d => d.Nascimento).HasColumnName("Nascimento_Paciente");
            this.Property(d => d.Sexo).HasColumnName("Sexo_Paciente");
        }
    }
}
