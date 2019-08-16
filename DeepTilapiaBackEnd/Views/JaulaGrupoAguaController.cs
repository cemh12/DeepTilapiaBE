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
    public class JaulaGrupoAguaController : Controller
    {
        private readonly ApplicationDbContext _context;

        public JaulaGrupoAguaController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: JaulaGrupoAgua
        public async Task<IActionResult> Index()
        {
            return View(await _context.JaulasGrupoAguas.ToListAsync());
        }

        // GET: JaulaGrupoAgua/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jaulaGrupoAgua = await _context.JaulasGrupoAguas
                .FirstOrDefaultAsync(m => m.ID == id);
            if (jaulaGrupoAgua == null)
            {
                return NotFound();
            }

            return View(jaulaGrupoAgua);
        }

        // GET: JaulaGrupoAgua/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: JaulaGrupoAgua/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,IDJaulaGrupo,Fecha,Temperatura,Ph,Turbidez,Iluminacion")] JaulaGrupoAgua jaulaGrupoAgua)
        {
            if (ModelState.IsValid)
            {
                _context.Add(jaulaGrupoAgua);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(jaulaGrupoAgua);
        }

        // GET: JaulaGrupoAgua/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jaulaGrupoAgua = await _context.JaulasGrupoAguas.FindAsync(id);
            if (jaulaGrupoAgua == null)
            {
                return NotFound();
            }
            return View(jaulaGrupoAgua);
        }

        // POST: JaulaGrupoAgua/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,IDJaulaGrupo,Fecha,Temperatura,Ph,Turbidez,Iluminacion")] JaulaGrupoAgua jaulaGrupoAgua)
        {
            if (id != jaulaGrupoAgua.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(jaulaGrupoAgua);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!JaulaGrupoAguaExists(jaulaGrupoAgua.ID))
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
            return View(jaulaGrupoAgua);
        }

        // GET: JaulaGrupoAgua/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jaulaGrupoAgua = await _context.JaulasGrupoAguas
                .FirstOrDefaultAsync(m => m.ID == id);
            if (jaulaGrupoAgua == null)
            {
                return NotFound();
            }

            return View(jaulaGrupoAgua);
        }

        // POST: JaulaGrupoAgua/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var jaulaGrupoAgua = await _context.JaulasGrupoAguas.FindAsync(id);
            _context.JaulasGrupoAguas.Remove(jaulaGrupoAgua);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool JaulaGrupoAguaExists(int id)
        {
            return _context.JaulasGrupoAguas.Any(e => e.ID == id);
        }
    }
}
