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
    public class JaulasController : Controller
    {
        private readonly ApplicationDbContext _context;

        public JaulasController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Jaulas
        public async Task<IActionResult> Index()
        {
            return View(await _context.Jaulas.ToListAsync());
        }

        // GET: Jaulas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jaula = await _context.Jaulas
                .FirstOrDefaultAsync(m => m.ID == id);
            if (jaula == null)
            {
                return NotFound();
            }

            return View(jaula);
        }

        // GET: Jaulas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Jaulas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,TipoJaula,Ubicacion,Ancho,Largo,Profundidad,Volumen,Capacidad")] Jaula jaula)
        {
            if (ModelState.IsValid)
            {
                _context.Add(jaula);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(jaula);
        }

        // GET: Jaulas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jaula = await _context.Jaulas.FindAsync(id);
            if (jaula == null)
            {
                return NotFound();
            }
            return View(jaula);
        }

        // POST: Jaulas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,TipoJaula,Ubicacion,Ancho,Largo,Profundidad,Volumen,Capacidad")] Jaula jaula)
        {
            if (id != jaula.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(jaula);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!JaulaExists(jaula.ID))
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
            return View(jaula);
        }

        // GET: Jaulas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jaula = await _context.Jaulas
                .FirstOrDefaultAsync(m => m.ID == id);
            if (jaula == null)
            {
                return NotFound();
            }

            return View(jaula);
        }

        // POST: Jaulas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var jaula = await _context.Jaulas.FindAsync(id);
            _context.Jaulas.Remove(jaula);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool JaulaExists(int id)
        {
            return _context.Jaulas.Any(e => e.ID == id);
        }
    }
}
