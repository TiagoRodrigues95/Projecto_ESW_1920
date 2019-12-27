using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CandidaturaE_.Data;
using CandidaturaE_.Models;

namespace CandidaturaE_.Controllers
{
    public class AtasController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AtasController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Atas
        public async Task<IActionResult> Index()
        {
            return View(await _context.Ata.ToListAsync());
        }

        // GET: Atas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ata = await _context.Ata
                .FirstOrDefaultAsync(m => m.AtaId == id);
            if (ata == null)
            {
                return NotFound();
            }

            return View(ata);
        }

        // GET: Atas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Atas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("AtaId,Titulo,Descricao,MR_Id,UtilizadorId")] Ata ata)
        {
            if (ModelState.IsValid)
            {
                _context.Add(ata);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(ata);
        }

        // GET: Atas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ata = await _context.Ata.FindAsync(id);
            if (ata == null)
            {
                return NotFound();
            }
            return View(ata);
        }

        // POST: Atas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("AtaId,Titulo,Descricao,MR_Id,UtilizadorId")] Ata ata)
        {
            if (id != ata.AtaId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(ata);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AtaExists(ata.AtaId))
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
            return View(ata);
        }

        // GET: Atas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ata = await _context.Ata
                .FirstOrDefaultAsync(m => m.AtaId == id);
            if (ata == null)
            {
                return NotFound();
            }

            return View(ata);
        }

        // POST: Atas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var ata = await _context.Ata.FindAsync(id);
            _context.Ata.Remove(ata);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AtaExists(int id)
        {
            return _context.Ata.Any(e => e.AtaId == id);
        }
    }
}
