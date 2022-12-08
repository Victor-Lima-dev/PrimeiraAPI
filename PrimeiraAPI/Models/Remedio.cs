using System;

namespace PrimeiraAPI.Models
{
    public class Remedio
    {
        public int RemedioId { get; set; }
        public string? Nome { get; set; }
        public string? Tipo { get; set; }
        public float Estoque { get; set; }
        public double Preco { get; set; }
        public string? Descricao { get; set; }

        public DateTime DataCadastro { get; set; }
         
        public int AnimalId { get; set; }
        public Animal? Animal { get; set; }


    }
}
