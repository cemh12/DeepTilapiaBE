using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DeepTilapiaBackEnd.Data;
using DeepTilapiaBackEnd.Models;

namespace DeepTilapiaBackEnd.Views
{
    [Route("api/[controller]")]
    [ApiController]
    public class JaulasRestController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public JaulasRestController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/JaulasRest
        [HttpGet]
        public IEnumerable<Jaula> GetJaulas()
        {
            return _context.Jaulas;
        }

        // GET: api/JaulasRest/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetJaula([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var jaula = await _context.Jaulas.FindAsync(id);

            if (jaula == null)
            {
                return NotFound();
            }

            return Ok(jaula);
        }

        // PUT: api/JaulasRest/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutJaula([FromRoute] int id, [FromBody] Jaula jaula)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != jaula.ID)
            {
                return BadRequest();
            }

            _context.Entry(jaula).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!JaulaExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/JaulasRest
        [HttpPost]
        public async Task<IActionResult> PostJaula([FromBody] Jaula jaula)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Jaulas.Add(jaula);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetJaula", new { id = jaula.ID }, jaula);
        }

        // DELETE: api/JaulasRest/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteJaula([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var jaula = await _context.Jaulas.FindAsync(id);
            if (jaula == null)
            {
                return NotFound();
            }

            _context.Jaulas.Remove(jaula);
            await _context.SaveChangesAsync();

            return Ok(jaula);
        }

        private bool JaulaExists(int id)
        {
            return _context.Jaulas.Any(e => e.ID == id);
        }
    }
}