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
    public class JaulaGrupoMuertesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public JaulaGrupoMuertesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: JaulaGrupoMuertes
        public async Task<IActionResult> Index()
        {
            return View(await _context.JaulasGrupoMuertes.ToListAsync());
        }

        // GET: JaulaGrupoMuertes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jaulaGrupoMuertes = await _context.JaulasGrupoMuertes
                .FirstOrDefaultAsync(m => m.ID == id);
            if (jaulaGrupoMuertes == null)
            {
                return NotFound();
            }

            return View(jaulaGrupoMuertes);
        }

        // GET: JaulaGrupoMuertes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: JaulaGrupoMuertes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Fecha,Cantidad")] JaulaGrupoMuertes jaulaGrupoMuertes)
        {
            if (ModelState.IsValid)
            {
                _context.Add(jaulaGrupoMuertes);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(jaulaGrupoMuertes);
        }

        // GET: JaulaGrupoMuertes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jaulaGrupoMuertes = await _context.JaulasGrupoMuertes.FindAsync(id);
            if (jaulaGrupoMuertes == null)
            {
                return NotFound();
            }
            return View(jaulaGrupoMuertes);
        }

        // POST: JaulaGrupoMuertes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Fecha,Cantidad")] JaulaGrupoMuertes jaulaGrupoMuertes)
        {
            if (id != jaulaGrupoMuertes.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(jaulaGrupoMuertes);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!JaulaGrupoMuertesExists(jaulaGrupoMuertes.ID))
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
            return View(jaulaGrupoMuertes);
        }

        // GET: JaulaGrupoMuertes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jaulaGrupoMuertes = await _context.JaulasGrupoMuertes
                .FirstOrDefaultAsync(m => m.ID == id);
            if (jaulaGrupoMuertes == null)
            {
                return NotFound();
            }

            return View(jaulaGrupoMuertes);
        }

        // POST: JaulaGrupoMuertes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var jaulaGrupoMuertes = await _context.JaulasGrupoMuertes.FindAsync(id);
            _context.JaulasGrupoMuertes.Remove(jaulaGrupoMuertes);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool JaulaGrupoMuertesExists(int id)
        {
            return _context.JaulasGrupoMuertes.Any(e => e.ID == id);
        }
    }
}
