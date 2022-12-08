using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PrimeiraAPI.Context;
using PrimeiraAPI.Models;

namespace PrimeiraAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AnimaisController : ControllerBase
    {
        //acessar banco de dados somente leitura
        private readonly AppDbContext _context;
        //construtuor
        public AnimaisController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Animal>> Get()
        {
            //lista de animais
            var animais = _context.Animais.ToList();


            //verificar se Animal é null
            if (animais == null)
            {
                return NotFound();
            }
            return animais.ToList();
        }

        //metodo para retornar um animal por id
        [HttpGet("{id:int}", Name = "ObterAnimal")]
        public ActionResult<Animal> Get(int id)
        {
            var animal = _context.Animais.FirstOrDefault(x => x.AnimalId == id);

            //verificar se Animal é null
            if (animal == null)
            {
                return NotFound("Produto nao encontrado");
            }
            //retornar o animal pelo id
            return animal;
        }

        [HttpPost]
        public ActionResult Post(Animal animal)
        {
            if (animal is null)
            {
                BadRequest();
            }

            _context.Animais.Add(animal);
            _context.SaveChanges();

            return new CreatedAtRouteResult("ObterAnimal", new { id = animal.AnimalId }, animal);

        }



        //template de rota /animais/id
        [HttpPut("{id}")]
        public ActionResult Put(int id, Animal animal)
        {
            if (id != animal.AnimalId)
            {
                return BadRequest();
            }

            _context.Entry(animal).State = EntityState.Modified;
            _context.SaveChanges();
            
            return Ok(animal);
        }

        //metodo para excluir um animal
        [HttpDelete("{id:int}")]
        public ActionResult<Animal> Delete(int id)
        {
            var animal = _context.Animais.FirstOrDefault(x => x.AnimalId == id);

            if (animal == null)
            {
                return NotFound();
            }

            _context.Animais.Remove(animal);
            _context.SaveChanges();

            return Ok(animal);
        }
    }
   

    }
  
