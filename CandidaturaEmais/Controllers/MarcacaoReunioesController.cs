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
    public class MarcacaoReunioesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MarcacaoReunioesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: MarcacaoReunioes
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.MarcacaoReuniao.Include(m => m.Hora);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: MarcacaoReunioes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var marcacaoReuniao = await _context.MarcacaoReuniao
                .Include(m => m.Hora)
                .FirstOrDefaultAsync(m => m.MarcacaoReuniaoId == id);
            if (marcacaoReuniao == null)
            {
                return NotFound();
            }

            return View(marcacaoReuniao);
        }

        // GET: MarcacaoReunioes/Create
        public IActionResult Create()
        {
            ViewData["HoraId"] = new SelectList(_context.Hora, "HoraId", "HoraId");
            return View();
        }

        // POST: MarcacaoReunioes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MarcacaoReuniaoId,HoraId,AlunoId")] MarcacaoReuniao marcacaoReuniao)
        {
            if (ModelState.IsValid)
            {
                _context.Add(marcacaoReuniao);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["HoraId"] = new SelectList(_context.Hora, "HoraId", "HoraId", marcacaoReuniao.HoraId);
            return View(marcacaoReuniao);
        }

        // GET: MarcacaoReunioes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var marcacaoReuniao = await _context.MarcacaoReuniao.FindAsync(id);
            if (marcacaoReuniao == null)
            {
                return NotFound();
            }
            ViewData["HoraId"] = new SelectList(_context.Hora, "HoraId", "HoraId", marcacaoReuniao.HoraId);
            return View(marcacaoReuniao);
        }

        // POST: MarcacaoReunioes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MarcacaoReuniaoId,HoraId,AlunoId")] MarcacaoReuniao marcacaoReuniao)
        {
            if (id != marcacaoReuniao.MarcacaoReuniaoId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(marcacaoReuniao);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MarcacaoReuniaoExists(marcacaoReuniao.MarcacaoReuniaoId))
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
            ViewData["HoraId"] = new SelectList(_context.Hora, "HoraId", "HoraId", marcacaoReuniao.HoraId);
            return View(marcacaoReuniao);
        }

        // GET: MarcacaoReunioes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var marcacaoReuniao = await _context.MarcacaoReuniao
                .Include(m => m.Hora)
                .FirstOrDefaultAsync(m => m.MarcacaoReuniaoId == id);
            if (marcacaoReuniao == null)
            {
                return NotFound();
            }

            return View(marcacaoReuniao);
        }

        // POST: MarcacaoReunioes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var marcacaoReuniao = await _context.MarcacaoReuniao.FindAsync(id);
            _context.MarcacaoReuniao.Remove(marcacaoReuniao);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MarcacaoReuniaoExists(int id)
        {
            return _context.MarcacaoReuniao.Any(e => e.MarcacaoReuniaoId == id);
        }
    }
}
