using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PrimeiraAPI.Migrations
{
    /// <inheritdoc />
    public partial class PopularAnimais2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            
            migrationBuilder.Sql("INSERT INTO Animais (Nome, Especie, Sexo) VALUES ('Kana', 'Cachorro', 'Femea')");
            
            migrationBuilder.Sql("INSERT INTO Animais (Nome, Especie, Sexo) VALUES ('Zeca', 'Cachorro', 'Macho')");
            //popular tabela animal
            migrationBuilder.Sql("INSERT INTO Animais (Nome, Especie, Sexo) VALUES ('Pirulito', 'Cachorro', 'Macho')");
            
            migrationBuilder.Sql("INSERT INTO Animais (Nome, Especie, Sexo) VALUES ('Duque', 'Cachorro', 'Macho')");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Animais");


        }
    }
}
