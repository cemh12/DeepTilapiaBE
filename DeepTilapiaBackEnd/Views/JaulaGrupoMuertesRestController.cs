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
    public class JaulaGrupoMuertesRestController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public JaulaGrupoMuertesRestController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/JaulaGrupoMuertesRest
        [HttpGet]
        public IEnumerable<JaulaGrupoMuertes> GetJaulasGrupoMuertes()
        {
            return _context.JaulasGrupoMuertes;
        }

        // GET: api/JaulaGrupoMuertesRest/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetJaulaGrupoMuertes([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var jaulaGrupoMuertes = await _context.JaulasGrupoMuertes.FindAsync(id);

            if (jaulaGrupoMuertes == null)
            {
                return NotFound();
            }

            return Ok(jaulaGrupoMuertes);
        }

        // PUT: api/JaulaGrupoMuertesRest/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutJaulaGrupoMuertes([FromRoute] int id, [FromBody] JaulaGrupoMuertes jaulaGrupoMuertes)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != jaulaGrupoMuertes.ID)
            {
                return BadRequest();
            }

            _context.Entry(jaulaGrupoMuertes).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!JaulaGrupoMuertesExists(id))
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

        // POST: api/JaulaGrupoMuertesRest
        [HttpPost]
        public async Task<IActionResult> PostJaulaGrupoMuertes([FromBody] JaulaGrupoMuertes jaulaGrupoMuertes)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.JaulasGrupoMuertes.Add(jaulaGrupoMuertes);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetJaulaGrupoMuertes", new { id = jaulaGrupoMuertes.ID }, jaulaGrupoMuertes);
        }

        // DELETE: api/JaulaGrupoMuertesRest/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteJaulaGrupoMuertes([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var jaulaGrupoMuertes = await _context.JaulasGrupoMuertes.FindAsync(id);
            if (jaulaGrupoMuertes == null)
            {
                return NotFound();
            }

            _context.JaulasGrupoMuertes.Remove(jaulaGrupoMuertes);
            await _context.SaveChangesAsync();

            return Ok(jaulaGrupoMuertes);
        }

        private bool JaulaGrupoMuertesExists(int id)
        {
            return _context.JaulasGrupoMuertes.Any(e => e.ID == id);
        }
    }
}