using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidade;

namespace Controllers.map
{
    internal class ConsultaMap : EntityTypeConfiguration<Consulta>
    {
        public ConsultaMap()
        {
            this.HasKey(d => d.IdConsulta);
            this.Property(d => d.IdConsulta).HasColumnName("Id_Consulta");
            this.Property(d => d.IdDentista).HasColumnName("Id_Dentista");
            this.Property(d => d.IdPaciente).HasColumnName("Id_Paciente");
            this.Property(d => d.Data).HasColumnName("Data_Consulta");
            this.Property(d => d.HoraMarcada).HasColumnName("Hora_Marcada");
            this.Property(d => d.HoraInicio).HasColumnName("Hora_Inicio");
            this.Property(d => d.HoraFim).HasColumnName("Hora_Fim");
            this.Property(d => d.Observacao).HasColumnName("Observacao_Consulta");
            this.Property(d => d.Status).HasColumnName("Status_Consulta");
        }
    }
}
