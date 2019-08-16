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
    public class JaulaGrupoAguaRestController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public JaulaGrupoAguaRestController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/JaulaGrupoAguaRest
        [HttpGet]
        public IEnumerable<JaulaGrupoAgua> GetJaulasGrupoAguas()
        {
            return _context.JaulasGrupoAguas;
        }

        // GET: api/JaulaGrupoAguaRest/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetJaulaGrupoAgua([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var jaulaGrupoAgua = await _context.JaulasGrupoAguas.FindAsync(id);

            if (jaulaGrupoAgua == null)
            {
                return NotFound();
            }

            return Ok(jaulaGrupoAgua);
        }

        // PUT: api/JaulaGrupoAguaRest/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutJaulaGrupoAgua([FromRoute] int id, [FromBody] JaulaGrupoAgua jaulaGrupoAgua)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != jaulaGrupoAgua.ID)
            {
                return BadRequest();
            }

            _context.Entry(jaulaGrupoAgua).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!JaulaGrupoAguaExists(id))
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

        // POST: api/JaulaGrupoAguaRest
        [HttpPost]
        public async Task<IActionResult> PostJaulaGrupoAgua([FromBody] JaulaGrupoAgua jaulaGrupoAgua)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.JaulasGrupoAguas.Add(jaulaGrupoAgua);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetJaulaGrupoAgua", new { id = jaulaGrupoAgua.ID }, jaulaGrupoAgua);
        }

        // DELETE: api/JaulaGrupoAguaRest/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteJaulaGrupoAgua([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var jaulaGrupoAgua = await _context.JaulasGrupoAguas.FindAsync(id);
            if (jaulaGrupoAgua == null)
            {
                return NotFound();
            }

            _context.JaulasGrupoAguas.Remove(jaulaGrupoAgua);
            await _context.SaveChangesAsync();

            return Ok(jaulaGrupoAgua);
        }

        private bool JaulaGrupoAguaExists(int id)
        {
            return _context.JaulasGrupoAguas.Any(e => e.ID == id);
        }
    }
}