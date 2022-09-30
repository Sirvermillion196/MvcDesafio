using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AulaMVC.Migrations
{
    public partial class MvcCliente : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Salario",
                table: "Clientes");

            migrationBuilder.RenameColumn(
                name: "Idade",
                table: "Clientes",
                newName: "Nota");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Clientes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Comentario",
                table: "Clientes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Comentario",
                table: "Clientes");

            migrationBuilder.RenameColumn(
                name: "Nota",
                table: "Clientes",
                newName: "Idade");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Clientes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<double>(
                name: "Salario",
                table: "Clientes",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }
    }
}
