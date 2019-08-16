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
    public class AlimentoSuplidorRestController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public AlimentoSuplidorRestController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/AlimentoSuplidorRest
        [HttpGet]
        public IEnumerable<AlimentoSuplidor> GetAlimentosSuplidores()
        {
            return _context.AlimentosSuplidores;
        }

        // GET: api/AlimentoSuplidorRest/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetAlimentoSuplidor([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var alimentoSuplidor = await _context.AlimentosSuplidores.FindAsync(id);

            if (alimentoSuplidor == null)
            {
                return NotFound();
            }

            return Ok(alimentoSuplidor);
        }

        // PUT: api/AlimentoSuplidorRest/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAlimentoSuplidor([FromRoute] int id, [FromBody] AlimentoSuplidor alimentoSuplidor)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != alimentoSuplidor.ID)
            {
                return BadRequest();
            }

            _context.Entry(alimentoSuplidor).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AlimentoSuplidorExists(id))
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

        // POST: api/AlimentoSuplidorRest
        [HttpPost]
        public async Task<IActionResult> PostAlimentoSuplidor([FromBody] AlimentoSuplidor alimentoSuplidor)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.AlimentosSuplidores.Add(alimentoSuplidor);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAlimentoSuplidor", new { id = alimentoSuplidor.ID }, alimentoSuplidor);
        }

        // DELETE: api/AlimentoSuplidorRest/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAlimentoSuplidor([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var alimentoSuplidor = await _context.AlimentosSuplidores.FindAsync(id);
            if (alimentoSuplidor == null)
            {
                return NotFound();
            }

            _context.AlimentosSuplidores.Remove(alimentoSuplidor);
            await _context.SaveChangesAsync();

            return Ok(alimentoSuplidor);
        }

        private bool AlimentoSuplidorExists(int id)
        {
            return _context.AlimentosSuplidores.Any(e => e.ID == id);
        }
    }
}