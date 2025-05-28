using Controllers.map;
using Entidade;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Controllers.context
{
    public class SistemaContext : DbContext
    {
        public SistemaContext() : base("Server=DESKTOP-HIAB9BH\\SQLEXPRESS;Database=odonto;Integrated Security=True;")
        {

        }
        public DbSet<Consulta> Consultas { get; set; }
        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<Dentista> Dentistas { get; set; }
        public DbSet<Relatorio> Relatorios { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<SistemaContext>(null);
            modelBuilder.Configurations.Add(new DentistaMap());
            modelBuilder.Configurations.Add(new PacienteMap());
            modelBuilder.Configurations.Add(new ConsultaMap());
            modelBuilder.Configurations.Add(new RelatorioMap());
            base.OnModelCreating(modelBuilder);
        }
    }
}
