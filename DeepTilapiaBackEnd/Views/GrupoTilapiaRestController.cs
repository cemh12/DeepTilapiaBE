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
    public class GrupoTilapiaRestController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public GrupoTilapiaRestController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/GrupoTilapiaRest
        [HttpGet]
        public IEnumerable<GrupoTilapia> GetGrupos()
        {
            return _context.Grupos;
        }

        // GET: api/GrupoTilapiaRest/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetGrupoTilapia([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var grupoTilapia = await _context.Grupos.FindAsync(id);

            if (grupoTilapia == null)
            {
                return NotFound();
            }

            return Ok(grupoTilapia);
        }

        // PUT: api/GrupoTilapiaRest/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutGrupoTilapia([FromRoute] int id, [FromBody] GrupoTilapia grupoTilapia)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != grupoTilapia.ID)
            {
                return BadRequest();
            }

            _context.Entry(grupoTilapia).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GrupoTilapiaExists(id))
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

        // POST: api/GrupoTilapiaRest
        [HttpPost]
        public async Task<IActionResult> PostGrupoTilapia([FromBody] GrupoTilapia grupoTilapia)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Grupos.Add(grupoTilapia);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetGrupoTilapia", new { id = grupoTilapia.ID }, grupoTilapia);
        }

        // DELETE: api/GrupoTilapiaRest/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteGrupoTilapia([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var grupoTilapia = await _context.Grupos.FindAsync(id);
            if (grupoTilapia == null)
            {
                return NotFound();
            }

            _context.Grupos.Remove(grupoTilapia);
            await _context.SaveChangesAsync();

            return Ok(grupoTilapia);
        }

        private bool GrupoTilapiaExists(int id)
        {
            return _context.Grupos.Any(e => e.ID == id);
        }
    }
}