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
    public class JaulaGrupoAlimentoController : Controller
    {
        private readonly ApplicationDbContext _context;

        public JaulaGrupoAlimentoController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: JaulaGrupoAlimento
        public async Task<IActionResult> Index()
        {
            return View(await _context.JaulasGrupoAlimentos.ToListAsync());
        }

        // GET: JaulaGrupoAlimento/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jaulaGrupoAlimento = await _context.JaulasGrupoAlimentos
                .FirstOrDefaultAsync(m => m.ID == id);
            if (jaulaGrupoAlimento == null)
            {
                return NotFound();
            }

            return View(jaulaGrupoAlimento);
        }

        // GET: JaulaGrupoAlimento/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: JaulaGrupoAlimento/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,IDJaulaGrupo,IDAlimento,Cantidad,Fecha")] JaulaGrupoAlimento jaulaGrupoAlimento)
        {
            if (ModelState.IsValid)
            {
                _context.Add(jaulaGrupoAlimento);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(jaulaGrupoAlimento);
        }

        // GET: JaulaGrupoAlimento/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jaulaGrupoAlimento = await _context.JaulasGrupoAlimentos.FindAsync(id);
            if (jaulaGrupoAlimento == null)
            {
                return NotFound();
            }
            return View(jaulaGrupoAlimento);
        }

        // POST: JaulaGrupoAlimento/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,IDJaulaGrupo,IDAlimento,Cantidad,Fecha")] JaulaGrupoAlimento jaulaGrupoAlimento)
        {
            if (id != jaulaGrupoAlimento.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(jaulaGrupoAlimento);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!JaulaGrupoAlimentoExists(jaulaGrupoAlimento.ID))
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
            return View(jaulaGrupoAlimento);
        }

        // GET: JaulaGrupoAlimento/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jaulaGrupoAlimento = await _context.JaulasGrupoAlimentos
                .FirstOrDefaultAsync(m => m.ID == id);
            if (jaulaGrupoAlimento == null)
            {
                return NotFound();
            }

            return View(jaulaGrupoAlimento);
        }

        // POST: JaulaGrupoAlimento/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var jaulaGrupoAlimento = await _context.JaulasGrupoAlimentos.FindAsync(id);
            _context.JaulasGrupoAlimentos.Remove(jaulaGrupoAlimento);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool JaulaGrupoAlimentoExists(int id)
        {
            return _context.JaulasGrupoAlimentos.Any(e => e.ID == id);
        }
    }
}
