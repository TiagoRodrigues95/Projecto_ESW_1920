using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CandidaturaEmais.Data;
using CandidaturaEmais.Models;

namespace CandidaturaEmais.Controllers
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
            var applicationDbContext = _context.MarcacaoDuvidas.Include(m => m.Hora);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: MarcacaoDuvidas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var marcacaoDuvidas = await _context.MarcacaoDuvidas
                .Include(m => m.Hora)
                .FirstOrDefaultAsync(m => m.MD_Id == id);
            if (marcacaoDuvidas == null)
            {
                return NotFound();
            }

            return View(marcacaoDuvidas);
        }

        // GET: MarcacaoDuvidas/Create
        public IActionResult Create()
        {
            ViewData["HoraId"] = new SelectList(_context.Hora, "HoraId", "HoraId");
            return View();
        }

        // POST: MarcacaoDuvidas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MD_Id,HoraId,AlunoId")] MarcacaoDuvidas marcacaoDuvidas)
        {
            if (ModelState.IsValid)
            {
                _context.Add(marcacaoDuvidas);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["HoraId"] = new SelectList(_context.Hora, "HoraId", "HoraId", marcacaoDuvidas.HoraId);
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
            ViewData["HoraId"] = new SelectList(_context.Hora, "HoraId", "HoraId", marcacaoDuvidas.HoraId);
            return View(marcacaoDuvidas);
        }

        // POST: MarcacaoDuvidas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MD_Id,HoraId,AlunoId")] MarcacaoDuvidas marcacaoDuvidas)
        {
            if (id != marcacaoDuvidas.MD_Id)
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
                    if (!MarcacaoDuvidasExists(marcacaoDuvidas.MD_Id))
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
            ViewData["HoraId"] = new SelectList(_context.Hora, "HoraId", "HoraId", marcacaoDuvidas.HoraId);
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
                .Include(m => m.Hora)
                .FirstOrDefaultAsync(m => m.MD_Id == id);
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
            return _context.MarcacaoDuvidas.Any(e => e.MD_Id == id);
        }
    }
}
