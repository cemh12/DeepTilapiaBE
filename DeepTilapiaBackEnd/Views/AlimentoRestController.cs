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
    public class AlimentoRestController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public AlimentoRestController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/AlimentoRest
        [HttpGet]
        public IEnumerable<Alimento> GetAlimentos()
        {
            return _context.Alimentos;
        }

        // GET: api/AlimentoRest/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetAlimento([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var alimento = await _context.Alimentos.FindAsync(id);

            if (alimento == null)
            {
                return NotFound();
            }

            return Ok(alimento);
        }

        // PUT: api/AlimentoRest/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAlimento([FromRoute] int id, [FromBody] Alimento alimento)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != alimento.ID)
            {
                return BadRequest();
            }

            _context.Entry(alimento).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AlimentoExists(id))
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

        // POST: api/AlimentoRest
        [HttpPost]
        public async Task<IActionResult> PostAlimento([FromBody] Alimento alimento)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Alimentos.Add(alimento);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAlimento", new { id = alimento.ID }, alimento);
        }

        // DELETE: api/AlimentoRest/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAlimento([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var alimento = await _context.Alimentos.FindAsync(id);
            if (alimento == null)
            {
                return NotFound();
            }

            _context.Alimentos.Remove(alimento);
            await _context.SaveChangesAsync();

            return Ok(alimento);
        }

        private bool AlimentoExists(int id)
        {
            return _context.Alimentos.Any(e => e.ID == id);
        }
    }
}