using System.Collections.ObjectModel;

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
        public string? Nome { get; set; }
        public string? Especie { get; set; }
        public string? Sexo { get; set; }
        public ICollection<Remedio>? Remedios { get; set; }

    }
}
