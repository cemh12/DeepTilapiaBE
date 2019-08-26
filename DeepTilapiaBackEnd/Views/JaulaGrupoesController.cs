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
    public class JaulaGrupoesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public JaulaGrupoesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: JaulaGrupoes
        public async Task<IActionResult> Index()
        {
            return View(await _context.JaulaGrupos.ToListAsync());
        }

        // GET: JaulaGrupoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jaulaGrupo = await _context.JaulaGrupos
                .FirstOrDefaultAsync(m => m.ID == id);
            if (jaulaGrupo == null)
            {
                return NotFound();
            }

            return View(jaulaGrupo);
        }

        // GET: JaulaGrupoes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: JaulaGrupoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Cantidad,Activo,FechaInicio,FechaFin")] JaulaGrupo jaulaGrupo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(jaulaGrupo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(jaulaGrupo);
        }

        // GET: JaulaGrupoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jaulaGrupo = await _context.JaulaGrupos.FindAsync(id);
            if (jaulaGrupo == null)
            {
                return NotFound();
            }
            return View(jaulaGrupo);
        }

        // POST: JaulaGrupoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Cantidad,Activo,FechaInicio,FechaFin")] JaulaGrupo jaulaGrupo)
        {
            if (id != jaulaGrupo.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(jaulaGrupo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!JaulaGrupoExists(jaulaGrupo.ID))
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
            return View(jaulaGrupo);
        }

        // GET: JaulaGrupoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jaulaGrupo = await _context.JaulaGrupos
                .FirstOrDefaultAsync(m => m.ID == id);
            if (jaulaGrupo == null)
            {
                return NotFound();
            }

            return View(jaulaGrupo);
        }

        // POST: JaulaGrupoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var jaulaGrupo = await _context.JaulaGrupos.FindAsync(id);
            _context.JaulaGrupos.Remove(jaulaGrupo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool JaulaGrupoExists(int id)
        {
            return _context.JaulaGrupos.Any(e => e.ID == id);
        }
    }
}
