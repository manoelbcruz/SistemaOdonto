namespace Controllers.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class banco2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Relatorios",
                c => new
                    {
                        Nome_Relatorio = c.String(nullable: false, maxLength: 128),
                        Endereco_Relatorio = c.String(),
                        Mensagem_Relatorio = c.String(),
                        Telefone_Relatorio = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.Nome_Relatorio);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Relatorios");
        }
    }
}
