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
    public class SuplidorAlimentoRestController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public SuplidorAlimentoRestController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/SuplidorAlimentoRest
        [HttpGet]
        public IEnumerable<SuplidorAlimento> GetSuplidorAlimentos()
        {
            return _context.SuplidorAlimentos;
        }

        // GET: api/SuplidorAlimentoRest/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetSuplidorAlimento([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var suplidorAlimento = await _context.SuplidorAlimentos.FindAsync(id);

            if (suplidorAlimento == null)
            {
                return NotFound();
            }

            return Ok(suplidorAlimento);
        }

        // PUT: api/SuplidorAlimentoRest/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSuplidorAlimento([FromRoute] int id, [FromBody] SuplidorAlimento suplidorAlimento)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != suplidorAlimento.ID)
            {
                return BadRequest();
            }

            _context.Entry(suplidorAlimento).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SuplidorAlimentoExists(id))
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

        // POST: api/SuplidorAlimentoRest
        [HttpPost]
        public async Task<IActionResult> PostSuplidorAlimento([FromBody] SuplidorAlimento suplidorAlimento)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.SuplidorAlimentos.Add(suplidorAlimento);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSuplidorAlimento", new { id = suplidorAlimento.ID }, suplidorAlimento);
        }

        // DELETE: api/SuplidorAlimentoRest/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSuplidorAlimento([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var suplidorAlimento = await _context.SuplidorAlimentos.FindAsync(id);
            if (suplidorAlimento == null)
            {
                return NotFound();
            }

            _context.SuplidorAlimentos.Remove(suplidorAlimento);
            await _context.SaveChangesAsync();

            return Ok(suplidorAlimento);
        }

        private bool SuplidorAlimentoExists(int id)
        {
            return _context.SuplidorAlimentos.Any(e => e.ID == id);
        }
    }
}