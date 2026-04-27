using CadastroEstudanteApi.data;
using CadastroEstudanteApi.models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CadastroEstudanteApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstudantesController : ControllerBase
    {
        private readonly AppDbContext _context;

        public EstudantesController(AppDbContext context)
        {
            _context = context;
        }
        //GET: api/Estudantes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Estudante>>> GetEstudantes()
        {
            return await _context.Estudantes.ToListAsync();
        }

        //GET: api/Estudantes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Estudante>> GetEstudante(int id)
        {
            var estudante = await _context.Estudantes.FindAsync(id);
            if (estudante == null)
            {
                return NotFound();
            }
            return estudante;
        }
        //POST: api/Estudantes
        [HttpPost]
        public async Task<ActionResult<Estudante>> PostEstudante(Estudante estudante)
        {
            _context.Estudantes.Add(estudante);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetEstudante), new { id = estudante.Id }, estudante);
        }

        //PUT: api/Estudantes/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEstudante(int id, Estudante estudante)
        {
            if (id != estudante.Id)
            {
                return BadRequest();
            }
            _context.Entry(estudante).State = EntityState.Modified;
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_context.Estudantes.Any(e => e.Id == id))
                {
                    return NotFound();
                }
                throw;
            }
            return NoContent();

        }

        //DELETE: api/Estudantes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEstudante(int id)
        {
            var estudante = await _context.Estudantes.FindAsync(id);
            if (estudante == null)
            {
                return NotFound();
            }
            _context.Estudantes.Remove(estudante);
            await _context.SaveChangesAsync();
            return NoContent();
        }




    }

    public interface IEmurable<T>
    {
    }
}