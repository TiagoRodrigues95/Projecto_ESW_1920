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
    public class MarcacaoDuvidasController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MarcacaoDuvidasController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: MarcacaoDuvidas
        public async Task<IActionResult> Index()
        {
            return View(await _context.MarcacaoDuvidas.ToListAsync());
        }

        // GET: MarcacaoDuvidas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var marcacaoDuvidas = await _context.MarcacaoDuvidas
                .FirstOrDefaultAsync(m => m.MRId == id);
            if (marcacaoDuvidas == null)
            {
                return NotFound();
            }

            return View(marcacaoDuvidas);
        }

        // GET: MarcacaoDuvidas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: MarcacaoDuvidas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MRId,HoraId,UtilizadorId")] MarcacaoDuvidas marcacaoDuvidas)
        {
            if (ModelState.IsValid)
            {
                _context.Add(marcacaoDuvidas);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(marcacaoDuvidas);
        }

        // GET: MarcacaoDuvidas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var marcacaoDuvidas = await _context.MarcacaoDuvidas.FindAsync(id);
            if (marcacaoDuvidas == null)
            {
                return NotFound();
            }
            return View(marcacaoDuvidas);
        }

        // POST: MarcacaoDuvidas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MRId,HoraId,UtilizadorId")] MarcacaoDuvidas marcacaoDuvidas)
        {
            if (id != marcacaoDuvidas.MRId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(marcacaoDuvidas);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MarcacaoDuvidasExists(marcacaoDuvidas.MRId))
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
            return View(marcacaoDuvidas);
        }

        // GET: MarcacaoDuvidas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var marcacaoDuvidas = await _context.MarcacaoDuvidas
                .FirstOrDefaultAsync(m => m.MRId == id);
            if (marcacaoDuvidas == null)
            {
                return NotFound();
            }

            return View(marcacaoDuvidas);
        }

        // POST: MarcacaoDuvidas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var marcacaoDuvidas = await _context.MarcacaoDuvidas.FindAsync(id);
            _context.MarcacaoDuvidas.Remove(marcacaoDuvidas);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MarcacaoDuvidasExists(int id)
        {
            return _context.MarcacaoDuvidas.Any(e => e.MRId == id);
        }
    }
}
