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
    public class JaulaGrupoAlimentoRestController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public JaulaGrupoAlimentoRestController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/JaulaGrupoAlimentoRest
        [HttpGet]
        public IEnumerable<JaulaGrupoAlimento> GetJaulasGrupoAlimentos()
        {
            return _context.JaulasGrupoAlimentos;
        }

        // GET: api/JaulaGrupoAlimentoRest/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetJaulaGrupoAlimento([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var jaulaGrupoAlimento = await _context.JaulasGrupoAlimentos.FindAsync(id);

            if (jaulaGrupoAlimento == null)
            {
                return NotFound();
            }

            return Ok(jaulaGrupoAlimento);
        }

        // PUT: api/JaulaGrupoAlimentoRest/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutJaulaGrupoAlimento([FromRoute] int id, [FromBody] JaulaGrupoAlimento jaulaGrupoAlimento)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != jaulaGrupoAlimento.ID)
            {
                return BadRequest();
            }

            _context.Entry(jaulaGrupoAlimento).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!JaulaGrupoAlimentoExists(id))
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

        // POST: api/JaulaGrupoAlimentoRest
        [HttpPost]
        public async Task<IActionResult> PostJaulaGrupoAlimento([FromBody] JaulaGrupoAlimento jaulaGrupoAlimento)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.JaulasGrupoAlimentos.Add(jaulaGrupoAlimento);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetJaulaGrupoAlimento", new { id = jaulaGrupoAlimento.ID }, jaulaGrupoAlimento);
        }

        // DELETE: api/JaulaGrupoAlimentoRest/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteJaulaGrupoAlimento([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var jaulaGrupoAlimento = await _context.JaulasGrupoAlimentos.FindAsync(id);
            if (jaulaGrupoAlimento == null)
            {
                return NotFound();
            }

            _context.JaulasGrupoAlimentos.Remove(jaulaGrupoAlimento);
            await _context.SaveChangesAsync();

            return Ok(jaulaGrupoAlimento);
        }

        private bool JaulaGrupoAlimentoExists(int id)
        {
            return _context.JaulasGrupoAlimentos.Any(e => e.ID == id);
        }
    }
}