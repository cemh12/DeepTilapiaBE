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
    public class JaulaGrupoRestController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public JaulaGrupoRestController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/JaulaGrupoRest
        [HttpGet]
        public IEnumerable<JaulaGrupo> GetJaulaGrupos()
        {
            return _context.JaulaGrupos;
        }

        // GET: api/JaulaGrupoRest/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetJaulaGrupo([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var jaulaGrupo = await _context.JaulaGrupos.FindAsync(id);

            if (jaulaGrupo == null)
            {
                return NotFound();
            }

            return Ok(jaulaGrupo);
        }

        // PUT: api/JaulaGrupoRest/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutJaulaGrupo([FromRoute] int id, [FromBody] JaulaGrupo jaulaGrupo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != jaulaGrupo.ID)
            {
                return BadRequest();
            }

            _context.Entry(jaulaGrupo).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!JaulaGrupoExists(id))
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

        // POST: api/JaulaGrupoRest
        [HttpPost]
        public async Task<IActionResult> PostJaulaGrupo([FromBody] JaulaGrupo jaulaGrupo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.JaulaGrupos.Add(jaulaGrupo);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetJaulaGrupo", new { id = jaulaGrupo.ID }, jaulaGrupo);
        }

        // DELETE: api/JaulaGrupoRest/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteJaulaGrupo([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var jaulaGrupo = await _context.JaulaGrupos.FindAsync(id);
            if (jaulaGrupo == null)
            {
                return NotFound();
            }

            _context.JaulaGrupos.Remove(jaulaGrupo);
            await _context.SaveChangesAsync();

            return Ok(jaulaGrupo);
        }

        private bool JaulaGrupoExists(int id)
        {
            return _context.JaulaGrupos.Any(e => e.ID == id);
        }
    }
}