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
    public class Inquerito_RespostaController : Controller
    {
        private readonly ApplicationDbContext _context;

        public Inquerito_RespostaController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Inquerito_Resposta
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Inquerito_Resposta.Include(i => i.Inquerito);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Inquerito_Resposta/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var inquerito_Resposta = await _context.Inquerito_Resposta
                .Include(i => i.Inquerito)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (inquerito_Resposta == null)
            {
                return NotFound();
            }

            return View(inquerito_Resposta);
        }

        // GET: Inquerito_Resposta/Create
        public IActionResult Create()
        {
            ViewData["InqueritoId"] = new SelectList(_context.Set<Inquerito>(), "InqueritoId", "InqueritoId");
            return View();
        }

        // POST: Inquerito_Resposta/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Data,AnoLetivo,Url,InqueritoId,UtilizadorId")] Inquerito_Resposta inquerito_Resposta)
        {
            if (ModelState.IsValid)
            {
                _context.Add(inquerito_Resposta);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["InqueritoId"] = new SelectList(_context.Set<Inquerito>(), "InqueritoId", "InqueritoId", inquerito_Resposta.InqueritoId);
            return View(inquerito_Resposta);
        }

        // GET: Inquerito_Resposta/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var inquerito_Resposta = await _context.Inquerito_Resposta.FindAsync(id);
            if (inquerito_Resposta == null)
            {
                return NotFound();
            }
            ViewData["InqueritoId"] = new SelectList(_context.Set<Inquerito>(), "InqueritoId", "InqueritoId", inquerito_Resposta.InqueritoId);
            return View(inquerito_Resposta);
        }

        // POST: Inquerito_Resposta/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Data,AnoLetivo,Url,InqueritoId,UtilizadorId")] Inquerito_Resposta inquerito_Resposta)
        {
            if (id != inquerito_Resposta.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(inquerito_Resposta);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Inquerito_RespostaExists(inquerito_Resposta.Id))
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
            ViewData["InqueritoId"] = new SelectList(_context.Set<Inquerito>(), "InqueritoId", "InqueritoId", inquerito_Resposta.InqueritoId);
            return View(inquerito_Resposta);
        }

        // GET: Inquerito_Resposta/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var inquerito_Resposta = await _context.Inquerito_Resposta
                .Include(i => i.Inquerito)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (inquerito_Resposta == null)
            {
                return NotFound();
            }

            return View(inquerito_Resposta);
        }

        // POST: Inquerito_Resposta/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var inquerito_Resposta = await _context.Inquerito_Resposta.FindAsync(id);
            _context.Inquerito_Resposta.Remove(inquerito_Resposta);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Inquerito_RespostaExists(int id)
        {
            return _context.Inquerito_Resposta.Any(e => e.Id == id);
        }
    }
}
