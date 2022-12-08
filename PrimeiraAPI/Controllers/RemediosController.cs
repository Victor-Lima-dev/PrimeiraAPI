using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PrimeiraAPI.Context;
using PrimeiraAPI.Models;

namespace PrimeiraAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class RemediosController : ControllerBase
    {
        
        private readonly AppDbContext _context;
        public RemediosController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Remedio>> Get()
        {
            var remedios = _context.Remedios.ToList();

            if (remedios == null)
            {
                return NotFound();
            }
            return remedios.ToList();
        }

        [HttpGet("{id:int}", Name = "ObterRemedio")]
        public ActionResult<Remedio> Get(int id)
        {
            var remedio = _context.Remedios.FirstOrDefault(x => x.RemedioId == id);

            if (remedio == null)
            {
                return NotFound("Produto nao encontrado");
            }
            return remedio;
        }

        [HttpPost]

        public ActionResult Post(Remedio remedio)
        {
            if (remedio is null)
            {
                BadRequest();
            }

            _context.Remedios.Add(remedio);
            _context.SaveChanges();
            return new CreatedAtRouteResult("ObterRemedio", new { id = remedio.RemedioId }, remedio);
        }

        [HttpPut("{id:int}")]

        public ActionResult Put(int id, Remedio remedio)
        {
            if (id != remedio.RemedioId)
            {
                return BadRequest();
            }

            _context.Entry(remedio).State = EntityState.Modified;
            _context.SaveChanges();
            return Ok(remedio);
        }

        [HttpDelete("{id:int}")]

        public ActionResult<Remedio> Delete(int id)
        {
            var remedio = _context.Remedios.FirstOrDefault(x => x.RemedioId == id);

            if (remedio == null)
            {
                return NotFound();
            }

            _context.Remedios.Remove(remedio);
            _context.SaveChanges();
            return Ok(remedio);
        }
        
        
    }
}
