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
    public class AlimentoSuplidorController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AlimentoSuplidorController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: AlimentoSuplidors
        public async Task<IActionResult> Index()
        {
            return View(await _context.AlimentosSuplidores.ToListAsync());
        }

        // GET: AlimentoSuplidors/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var alimentoSuplidor = await _context.AlimentosSuplidores
                .FirstOrDefaultAsync(m => m.ID == id);
            if (alimentoSuplidor == null)
            {
                return NotFound();
            }

            return View(alimentoSuplidor);
        }

        // GET: AlimentoSuplidors/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: AlimentoSuplidors/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,IDAlimento,IDSuplidor,Precio")] AlimentoSuplidor alimentoSuplidor)
        {
            if (ModelState.IsValid)
            {
                _context.Add(alimentoSuplidor);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(alimentoSuplidor);
        }

        // GET: AlimentoSuplidors/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var alimentoSuplidor = await _context.AlimentosSuplidores.FindAsync(id);
            if (alimentoSuplidor == null)
            {
                return NotFound();
            }
            return View(alimentoSuplidor);
        }

        // POST: AlimentoSuplidors/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,IDAlimento,IDSuplidor,Precio")] AlimentoSuplidor alimentoSuplidor)
        {
            if (id != alimentoSuplidor.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(alimentoSuplidor);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AlimentoSuplidorExists(alimentoSuplidor.ID))
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
            return View(alimentoSuplidor);
        }

        // GET: AlimentoSuplidors/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var alimentoSuplidor = await _context.AlimentosSuplidores
                .FirstOrDefaultAsync(m => m.ID == id);
            if (alimentoSuplidor == null)
            {
                return NotFound();
            }

            return View(alimentoSuplidor);
        }

        // POST: AlimentoSuplidors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var alimentoSuplidor = await _context.AlimentosSuplidores.FindAsync(id);
            _context.AlimentosSuplidores.Remove(alimentoSuplidor);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AlimentoSuplidorExists(int id)
        {
            return _context.AlimentosSuplidores.Any(e => e.ID == id);
        }
    }
}
