namespace WindowsAppEscuela.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Evaluacion", "IDDetalle", "dbo.Detalle");
            DropForeignKey("dbo.Evaluacion", "IDTipo", "dbo.Tipo");
            DropIndex("dbo.Evaluacion", new[] { "IDTipo" });
            DropIndex("dbo.Evaluacion", new[] { "IDDetalle" });
            RenameColumn(table: "dbo.Evaluacion", name: "Estudiante_IDEstudiante", newName: "IdEstudiante");
            RenameIndex(table: "dbo.Evaluacion", name: "IX_Estudiante_IDEstudiante", newName: "IX_IdEstudiante");
            AlterColumn("dbo.Evaluacion", "IDTipo", c => c.Int());
            AlterColumn("dbo.Evaluacion", "IDDetalle", c => c.Int());
            CreateIndex("dbo.Evaluacion", "IDTipo");
            CreateIndex("dbo.Evaluacion", "IDDetalle");
            AddForeignKey("dbo.Evaluacion", "IDDetalle", "dbo.Detalle", "IDDetalle");
            AddForeignKey("dbo.Evaluacion", "IDTipo", "dbo.Tipo", "IdTipo");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Evaluacion", "IDTipo", "dbo.Tipo");
            DropForeignKey("dbo.Evaluacion", "IDDetalle", "dbo.Detalle");
            DropIndex("dbo.Evaluacion", new[] { "IDDetalle" });
            DropIndex("dbo.Evaluacion", new[] { "IDTipo" });
            AlterColumn("dbo.Evaluacion", "IDDetalle", c => c.Int(nullable: false));
            AlterColumn("dbo.Evaluacion", "IDTipo", c => c.Int(nullable: false));
            RenameIndex(table: "dbo.Evaluacion", name: "IX_IdEstudiante", newName: "IX_Estudiante_IDEstudiante");
            RenameColumn(table: "dbo.Evaluacion", name: "IdEstudiante", newName: "Estudiante_IDEstudiante");
            CreateIndex("dbo.Evaluacion", "IDDetalle");
            CreateIndex("dbo.Evaluacion", "IDTipo");
            AddForeignKey("dbo.Evaluacion", "IDTipo", "dbo.Tipo", "IdTipo", cascadeDelete: false);
            AddForeignKey("dbo.Evaluacion", "IDDetalle", "dbo.Detalle", "IDDetalle", cascadeDelete: false);
        }
    }
}
