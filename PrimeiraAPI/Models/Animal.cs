using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace PrimeiraAPI.Models
{
    public class Animal
    {

        //construtor com a colecao de remedios
        public Animal()
        {
            Remedios = new Collection<Remedio>();
        }

        public int AnimalId { get; set; }

        [Required]
        [MaxLength(80)]
        public string? Nome { get; set; }
        [Required]
        [MaxLength(80)]
        public string? Especie { get; set; }
        [Required]
        [MaxLength(6)]
        public string? Sexo { get; set; }
        public ICollection<Remedio>? Remedios { get; set; }

    }
}
