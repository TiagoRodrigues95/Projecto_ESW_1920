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
    public class PFCsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PFCsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: PFCs
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.PFC.Include(p => p.Aluno).Include(p => p.Docente);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: PFCs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pFC = await _context.PFC
                .Include(p => p.Aluno)
                .Include(p => p.Docente)
                .FirstOrDefaultAsync(m => m.PFCId == id);
            if (pFC == null)
            {
                return NotFound();
            }

            return View(pFC);
        }

        // GET: PFCs/Create
        public IActionResult Create()
        {
            ViewData["AlunoId"] = new SelectList(_context.Users, "Id", "Id");
            ViewData["DocenteId"] = new SelectList(_context.Users, "Id", "Id");
            return View();
        }

        // POST: PFCs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PFCId,Timestamp,PropostaUrl,DocenteId,AlunoId")] PFC pFC)
        {
            if (ModelState.IsValid)
            {
                _context.Add(pFC);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["AlunoId"] = new SelectList(_context.Users, "Id", "Id", pFC.AlunoId);
            ViewData["DocenteId"] = new SelectList(_context.Users, "Id", "Id", pFC.DocenteId);
            return View(pFC);
        }

        // GET: PFCs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pFC = await _context.PFC.FindAsync(id);
            if (pFC == null)
            {
                return NotFound();
            }
            ViewData["AlunoId"] = new SelectList(_context.Users, "Id", "Id", pFC.AlunoId);
            ViewData["DocenteId"] = new SelectList(_context.Users, "Id", "Id", pFC.DocenteId);
            return View(pFC);
        }

        // POST: PFCs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PFCId,Timestamp,PropostaUrl,DocenteId,AlunoId")] PFC pFC)
        {
            if (id != pFC.PFCId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pFC);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PFCExists(pFC.PFCId))
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
            ViewData["AlunoId"] = new SelectList(_context.Users, "Id", "Id", pFC.AlunoId);
            ViewData["DocenteId"] = new SelectList(_context.Users, "Id", "Id", pFC.DocenteId);
            return View(pFC);
        }

        // GET: PFCs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pFC = await _context.PFC
                .Include(p => p.Aluno)
                .Include(p => p.Docente)
                .FirstOrDefaultAsync(m => m.PFCId == id);
            if (pFC == null)
            {
                return NotFound();
            }

            return View(pFC);
        }

        // POST: PFCs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var pFC = await _context.PFC.FindAsync(id);
            _context.PFC.Remove(pFC);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PFCExists(int id)
        {
            return _context.PFC.Any(e => e.PFCId == id);
        }
    }
}
