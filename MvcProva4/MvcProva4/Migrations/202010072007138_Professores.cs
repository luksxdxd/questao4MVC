namespace MvcProva4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Professores : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Professors",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false),
                        Endereco = c.String(),
                        Telefone = c.Int(nullable: false),
                        Email = c.String(),
                        Disciplina = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Professors");
        }
    }
}
