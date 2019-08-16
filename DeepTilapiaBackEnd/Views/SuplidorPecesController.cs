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
    public class SuplidorPecesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SuplidorPecesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: SuplidorPeces
        public async Task<IActionResult> Index()
        {
            return View(await _context.SuplidorAlevines.ToListAsync());
        }

        // GET: SuplidorPeces/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var suplidorPeces = await _context.SuplidorAlevines
                .FirstOrDefaultAsync(m => m.ID == id);
            if (suplidorPeces == null)
            {
                return NotFound();
            }

            return View(suplidorPeces);
        }

        // GET: SuplidorPeces/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: SuplidorPeces/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Nombre,Direccion,Email,Encargado")] SuplidorPeces suplidorPeces)
        {
            if (ModelState.IsValid)
            {
                _context.Add(suplidorPeces);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(suplidorPeces);
        }

        // GET: SuplidorPeces/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var suplidorPeces = await _context.SuplidorAlevines.FindAsync(id);
            if (suplidorPeces == null)
            {
                return NotFound();
            }
            return View(suplidorPeces);
        }

        // POST: SuplidorPeces/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Nombre,Direccion,Email,Encargado")] SuplidorPeces suplidorPeces)
        {
            if (id != suplidorPeces.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(suplidorPeces);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SuplidorPecesExists(suplidorPeces.ID))
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
            return View(suplidorPeces);
        }

        // GET: SuplidorPeces/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var suplidorPeces = await _context.SuplidorAlevines
                .FirstOrDefaultAsync(m => m.ID == id);
            if (suplidorPeces == null)
            {
                return NotFound();
            }

            return View(suplidorPeces);
        }

        // POST: SuplidorPeces/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var suplidorPeces = await _context.SuplidorAlevines.FindAsync(id);
            _context.SuplidorAlevines.Remove(suplidorPeces);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SuplidorPecesExists(int id)
        {
            return _context.SuplidorAlevines.Any(e => e.ID == id);
        }
    }
}
