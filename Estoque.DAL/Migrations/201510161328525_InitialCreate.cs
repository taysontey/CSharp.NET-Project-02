namespace Estoque.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TB_FUNCIONARIO",
                c => new
                    {
                        CODFUNCIONARIO_PK = c.Int(nullable: false, identity: true),
                        NOME = c.String(nullable: false, maxLength: 50),
                        LOGIN = c.String(nullable: false, maxLength: 25),
                        SENHA = c.String(nullable: false, maxLength: 50),
                        FOTO = c.String(nullable: false, maxLength: 50),
                        DATACADASTRO = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.CODFUNCIONARIO_PK)
                .Index(t => t.LOGIN, unique: true, name: "IDX_LOGIN");
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.TB_FUNCIONARIO", "IDX_LOGIN");
            DropTable("dbo.TB_FUNCIONARIO");
        }
    }
}
