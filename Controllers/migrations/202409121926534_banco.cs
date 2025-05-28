namespace Controllers.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class banco : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Consultas",
                c => new
                    {
                        Id_Consulta = c.Int(nullable: false, identity: true),
                        Id_Paciente = c.Int(nullable: false),
                        Id_Dentista = c.Int(nullable: false),
                        Data_Consulta = c.DateTime(),
                        Hora_Marcada = c.DateTime(),
                        Hora_Inicio = c.DateTime(),
                        Hora_Fim = c.DateTime(),
                        Observacao_Consulta = c.String(),
                        Status_Consulta = c.String(),
                    })
                .PrimaryKey(t => t.Id_Consulta);
            
            CreateTable(
                "dbo.Dentista",
                c => new
                    {
                        Id_Dentista = c.Int(nullable: false, identity: true),
                        Nome_Dentista = c.String(),
                        Email_Dentista = c.String(),
                        Telefone_Dentista = c.Long(nullable: false),
                        Celular_Dentista = c.Long(nullable: false),
                        CRO = c.String(),
                    })
                .PrimaryKey(t => t.Id_Dentista);
            
            CreateTable(
                "dbo.Pacientes",
                c => new
                    {
                        Id_Paciente = c.Int(nullable: false, identity: true),
                        Nome_Paciente = c.String(),
                        Email_Paciente = c.String(),
                        Telefone_Paciente = c.Long(nullable: false),
                        Celular_Paciente = c.Long(nullable: false),
                        CEP_Paciente = c.String(),
                        Endereço_Paciente = c.String(),
                        Complemento = c.String(),
                        Nascimento_Paciente = c.DateTime(nullable: false),
                        Sexo_Paciente = c.String(),
                    })
                .PrimaryKey(t => t.Id_Paciente);

        }
        
        public override void Down()
        {
            DropTable("dbo.Pacientes");
            DropTable("dbo.Dentista");
            DropTable("dbo.Consultas");
        }
    }
}
