using Microsoft.EntityFrameworkCore.Migrations;
using DateTime = System.DateTime;

#nullable disable

namespace PrimeiraAPI.Migrations
{
    /// <inheritdoc />
    public partial class PopulaRemedios : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            
            
            migrationBuilder.Sql("INSERT INTO Remedios (Nome, Descricao, Preco, Tipo, AnimalId, Estoque, DataCadastro) VALUES ('Dipirona', 'Anti-inflamatório', 10.00, 'Comprimido', 1,15, getutcdate())");
           
            migrationBuilder.Sql("INSERT INTO Remedios (Nome, Descricao, Preco, Tipo, AnimalId, Estoque, DataCadastro) VALUES ('DorFlex', 'Anti-inflamatório', 10.00, 'Comprimido', 1,10, getutcdate())");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            
            migrationBuilder.Sql("DELETE FROM Remedios");
        }
    }
}
