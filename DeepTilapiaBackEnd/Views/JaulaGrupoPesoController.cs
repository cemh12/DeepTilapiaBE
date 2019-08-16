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
    public class JaulaGrupoPesoController : Controller
    {
        private readonly ApplicationDbContext _context;

        public JaulaGrupoPesoController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: JaulaGrupoPeso
        public async Task<IActionResult> Index()
        {
            return View(await _context.JaulasGrupoPeso.ToListAsync());
        }

        // GET: JaulaGrupoPeso/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jaulaGrupoPeso = await _context.JaulasGrupoPeso
                .FirstOrDefaultAsync(m => m.ID == id);
            if (jaulaGrupoPeso == null)
            {
                return NotFound();
            }

            return View(jaulaGrupoPeso);
        }

        // GET: JaulaGrupoPeso/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: JaulaGrupoPeso/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,IDJaulaGrupo,PesoPromedio,Fecha")] JaulaGrupoPeso jaulaGrupoPeso)
        {
            if (ModelState.IsValid)
            {
                _context.Add(jaulaGrupoPeso);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(jaulaGrupoPeso);
        }

        // GET: JaulaGrupoPeso/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jaulaGrupoPeso = await _context.JaulasGrupoPeso.FindAsync(id);
            if (jaulaGrupoPeso == null)
            {
                return NotFound();
            }
            return View(jaulaGrupoPeso);
        }

        // POST: JaulaGrupoPeso/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,IDJaulaGrupo,PesoPromedio,Fecha")] JaulaGrupoPeso jaulaGrupoPeso)
        {
            if (id != jaulaGrupoPeso.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(jaulaGrupoPeso);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!JaulaGrupoPesoExists(jaulaGrupoPeso.ID))
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
            return View(jaulaGrupoPeso);
        }

        // GET: JaulaGrupoPeso/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jaulaGrupoPeso = await _context.JaulasGrupoPeso
                .FirstOrDefaultAsync(m => m.ID == id);
            if (jaulaGrupoPeso == null)
            {
                return NotFound();
            }

            return View(jaulaGrupoPeso);
        }

        // POST: JaulaGrupoPeso/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var jaulaGrupoPeso = await _context.JaulasGrupoPeso.FindAsync(id);
            _context.JaulasGrupoPeso.Remove(jaulaGrupoPeso);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool JaulaGrupoPesoExists(int id)
        {
            return _context.JaulasGrupoPeso.Any(e => e.ID == id);
        }
    }
}
