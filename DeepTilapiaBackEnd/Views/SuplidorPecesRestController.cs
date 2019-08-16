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
    public class SuplidorPecesRestController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public SuplidorPecesRestController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/SuplidorPecesRest
        [HttpGet]
        public IEnumerable<SuplidorPeces> GetSuplidorAlevines()
        {
            return _context.SuplidorAlevines;
        }

        // GET: api/SuplidorPecesRest/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetSuplidorPeces([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var suplidorPeces = await _context.SuplidorAlevines.FindAsync(id);

            if (suplidorPeces == null)
            {
                return NotFound();
            }

            return Ok(suplidorPeces);
        }

        // PUT: api/SuplidorPecesRest/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSuplidorPeces([FromRoute] int id, [FromBody] SuplidorPeces suplidorPeces)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != suplidorPeces.ID)
            {
                return BadRequest();
            }

            _context.Entry(suplidorPeces).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SuplidorPecesExists(id))
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

        // POST: api/SuplidorPecesRest
        [HttpPost]
        public async Task<IActionResult> PostSuplidorPeces([FromBody] SuplidorPeces suplidorPeces)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.SuplidorAlevines.Add(suplidorPeces);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSuplidorPeces", new { id = suplidorPeces.ID }, suplidorPeces);
        }

        // DELETE: api/SuplidorPecesRest/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSuplidorPeces([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var suplidorPeces = await _context.SuplidorAlevines.FindAsync(id);
            if (suplidorPeces == null)
            {
                return NotFound();
            }

            _context.SuplidorAlevines.Remove(suplidorPeces);
            await _context.SaveChangesAsync();

            return Ok(suplidorPeces);
        }

        private bool SuplidorPecesExists(int id)
        {
            return _context.SuplidorAlevines.Any(e => e.ID == id);
        }
    }
}