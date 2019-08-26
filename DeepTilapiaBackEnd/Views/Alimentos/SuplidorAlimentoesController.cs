using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DeepTilapiaBackEnd.Data;
using DeepTilapiaBackEnd.Models;

namespace DeepTilapiaBackEnd.Views.Alimentos
{
    public class SuplidorAlimentoesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SuplidorAlimentoesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: SuplidorAlimentoes
        public async Task<IActionResult> Index()
        {
            return View(await _context.SuplidorAlimentos.ToListAsync());
        }

        // GET: SuplidorAlimentoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var suplidorAlimento = await _context.SuplidorAlimentos
                .FirstOrDefaultAsync(m => m.ID == id);
            if (suplidorAlimento == null)
            {
                return NotFound();
            }

            return View(suplidorAlimento);
        }

        // GET: SuplidorAlimentoes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: SuplidorAlimentoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Nombre,Telefono,Direccion,Email,Encargado")] SuplidorAlimento suplidorAlimento)
        {
            if (ModelState.IsValid)
            {
                _context.Add(suplidorAlimento);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(suplidorAlimento);
        }

        // GET: SuplidorAlimentoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var suplidorAlimento = await _context.SuplidorAlimentos.FindAsync(id);
            if (suplidorAlimento == null)
            {
                return NotFound();
            }
            return View(suplidorAlimento);
        }

        // POST: SuplidorAlimentoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Nombre,Telefono,Direccion,Email,Encargado")] SuplidorAlimento suplidorAlimento)
        {
            if (id != suplidorAlimento.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(suplidorAlimento);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SuplidorAlimentoExists(suplidorAlimento.ID))
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
            return View(suplidorAlimento);
        }

        // GET: SuplidorAlimentoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var suplidorAlimento = await _context.SuplidorAlimentos
                .FirstOrDefaultAsync(m => m.ID == id);
            if (suplidorAlimento == null)
            {
                return NotFound();
            }

            return View(suplidorAlimento);
        }

        // POST: SuplidorAlimentoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var suplidorAlimento = await _context.SuplidorAlimentos.FindAsync(id);
            _context.SuplidorAlimentos.Remove(suplidorAlimento);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SuplidorAlimentoExists(int id)
        {
            return _context.SuplidorAlimentos.Any(e => e.ID == id);
        }
    }
}
