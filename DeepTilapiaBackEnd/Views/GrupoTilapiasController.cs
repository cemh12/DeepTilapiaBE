using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DeepTilapiaBackEnd.Data;
using DeepTilapiaBackEnd.Models;

namespace DeepTilapiaBackEnd.Views
{
    public class GrupoTilapiasController : Controller
    {
        private readonly ApplicationDbContext _context;

        public GrupoTilapiasController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: GrupoTilapias
        public async Task<IActionResult> Index()
        {
            return View(await _context.Grupos.ToListAsync());
        }

        // GET: GrupoTilapias/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var grupoTilapia = await _context.Grupos
                .FirstOrDefaultAsync(m => m.ID == id);
            if (grupoTilapia == null)
            {
                return NotFound();
            }

            return View(grupoTilapia);
        }

        // GET: GrupoTilapias/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: GrupoTilapias/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Cantidad,PesoPromedio,Etapa,FechaLlegada,CostoXPeso,CostoXUnidad,TemperaturaSuplidor,PhSuplidor,TemperaturaTransporte,PhTransporte,TemperaturaRecibimiento,PhRecibimiento,DistanciaTransporte,FechaSalida,MetodoTransporte")] GrupoTilapia grupoTilapia)
        {
            if (ModelState.IsValid)
            {
                _context.Add(grupoTilapia);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(grupoTilapia);
        }

        // GET: GrupoTilapias/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var grupoTilapia = await _context.Grupos.FindAsync(id);
            if (grupoTilapia == null)
            {
                return NotFound();
            }
            return View(grupoTilapia);
        }

        // POST: GrupoTilapias/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Cantidad,PesoPromedio,Etapa,FechaLlegada,CostoXPeso,CostoXUnidad,TemperaturaSuplidor,PhSuplidor,TemperaturaTransporte,PhTransporte,TemperaturaRecibimiento,PhRecibimiento,DistanciaTransporte,FechaSalida,MetodoTransporte")] GrupoTilapia grupoTilapia)
        {
            if (id != grupoTilapia.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(grupoTilapia);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GrupoTilapiaExists(grupoTilapia.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(grupoTilapia);
        }

        // GET: GrupoTilapias/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var grupoTilapia = await _context.Grupos
                .FirstOrDefaultAsync(m => m.ID == id);
            if (grupoTilapia == null)
            {
                return NotFound();
            }

            return View(grupoTilapia);
        }

        // POST: GrupoTilapias/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var grupoTilapia = await _context.Grupos.FindAsync(id);
            _context.Grupos.Remove(grupoTilapia);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GrupoTilapiaExists(int id)
        {
            return _context.Grupos.Any(e => e.ID == id);
        }
    }
}
