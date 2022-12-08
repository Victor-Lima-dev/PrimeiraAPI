using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PrimeiraAPI.Migrations
{
    /// <inheritdoc />
    public partial class PopulaRemedios2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Remedios (Nome, Descricao, Preco, Tipo, AnimalId, Estoque, DataCadastro) VALUES ('Aspirina', 'Anti-inflamatório', 10.00, 'Comprimido', 2,15, getutcdate())");

            migrationBuilder.Sql("INSERT INTO Remedios (Nome, Descricao, Preco, Tipo, AnimalId, Estoque, DataCadastro) VALUES ('Analgesico', 'Anti-inflamatório', 10.00, 'Comprimido', 3,10, getutcdate())");

            migrationBuilder.Sql("INSERT INTO Remedios (Nome, Descricao, Preco, Tipo, AnimalId, Estoque, DataCadastro) VALUES ('Teste', 'Anti-inflamatório', 10.00, 'Comprimido', 4,15, getutcdate())");


        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //deletar tabela
            migrationBuilder.Sql("DELETE FROM Remedios");
        }
    }
}
