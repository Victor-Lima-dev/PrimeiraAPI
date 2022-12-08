using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PrimeiraAPI.Models
{
    public class Remedio
    {
        public int RemedioId { get; set; }
        [Required]
        [MaxLength(80)]
        public string? Nome { get; set; }
        [Required]
        [MaxLength(80)]
        public string? Tipo { get; set; }
        public float Estoque { get; set; }
        [Required]
        [Column(TypeName = "decimal(10,2)")]
        public double Preco { get; set; }
        [Required]
        [MaxLength(80)]
        public string? Descricao { get; set; }

        public DateTime DataCadastro { get; set; }
         
        public int AnimalId { get; set; }
        public Animal? Animal { get; set; }


    }
}
