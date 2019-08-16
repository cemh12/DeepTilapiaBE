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
    public class JaulaGrupoPesoRestController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public JaulaGrupoPesoRestController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/JaulaGrupoPesoRest
        [HttpGet]
        public IEnumerable<JaulaGrupoPeso> GetJaulasGrupoPeso()
        {
            return _context.JaulasGrupoPeso;
        }

        // GET: api/JaulaGrupoPesoRest/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetJaulaGrupoPeso([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var jaulaGrupoPeso = await _context.JaulasGrupoPeso.FindAsync(id);

            if (jaulaGrupoPeso == null)
            {
                return NotFound();
            }

            return Ok(jaulaGrupoPeso);
        }

        // PUT: api/JaulaGrupoPesoRest/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutJaulaGrupoPeso([FromRoute] int id, [FromBody] JaulaGrupoPeso jaulaGrupoPeso)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != jaulaGrupoPeso.ID)
            {
                return BadRequest();
            }

            _context.Entry(jaulaGrupoPeso).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!JaulaGrupoPesoExists(id))
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

        // POST: api/JaulaGrupoPesoRest
        [HttpPost]
        public async Task<IActionResult> PostJaulaGrupoPeso([FromBody] JaulaGrupoPeso jaulaGrupoPeso)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.JaulasGrupoPeso.Add(jaulaGrupoPeso);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetJaulaGrupoPeso", new { id = jaulaGrupoPeso.ID }, jaulaGrupoPeso);
        }

        // DELETE: api/JaulaGrupoPesoRest/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteJaulaGrupoPeso([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var jaulaGrupoPeso = await _context.JaulasGrupoPeso.FindAsync(id);
            if (jaulaGrupoPeso == null)
            {
                return NotFound();
            }

            _context.JaulasGrupoPeso.Remove(jaulaGrupoPeso);
            await _context.SaveChangesAsync();

            return Ok(jaulaGrupoPeso);
        }

        private bool JaulaGrupoPesoExists(int id)
        {
            return _context.JaulasGrupoPeso.Any(e => e.ID == id);
        }
    }
}