namespace DotNePost.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Comentarios",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        comentario = c.String(),
                        autor = c.String(),
                        data = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Posts",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        conteudo = c.String(),
                        detalhe = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Posts");
            DropTable("dbo.Comentarios");
        }
    }
}
