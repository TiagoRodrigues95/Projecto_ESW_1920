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
    public class ReunioesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ReunioesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Reunioes
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Reuniao.Include(r => r.Ata).Include(r => r.Hora);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Reunioes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reuniao = await _context.Reuniao
                .Include(r => r.Ata)
                .Include(r => r.Hora)
                .FirstOrDefaultAsync(m => m.ReuniaoId == id);
            if (reuniao == null)
            {
                return NotFound();
            }

            return View(reuniao);
        }

        // GET: Reunioes/Create
        public IActionResult Create()
        {
            ViewData["AtaId"] = new SelectList(_context.AtaReuniao, "AtaId", "Descricao");
            ViewData["HoraId"] = new SelectList(_context.Hora, "HoraId", "UtilizadorId");
            return View();
        }

        // POST: Reunioes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ReuniaoId,HoraId,AtaId,UtilizadorIdParticipante,UtilizadorIdConvocado")] Reuniao reuniao)
        {
            if (ModelState.IsValid)
            {
                _context.Add(reuniao);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["AtaId"] = new SelectList(_context.AtaReuniao, "AtaId", "Descricao", reuniao.AtaId);
            ViewData["HoraId"] = new SelectList(_context.Hora, "HoraId", "UtilizadorId", reuniao.HoraId);
            return View(reuniao);
        }

        // GET: Reunioes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reuniao = await _context.Reuniao.FindAsync(id);
            if (reuniao == null)
            {
                return NotFound();
            }
            ViewData["AtaId"] = new SelectList(_context.AtaReuniao, "AtaId", "Descricao", reuniao.AtaId);
            ViewData["HoraId"] = new SelectList(_context.Hora, "HoraId", "UtilizadorId", reuniao.HoraId);
            return View(reuniao);
        }

        // POST: Reunioes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ReuniaoId,HoraId,AtaId,UtilizadorIdParticipante,UtilizadorIdConvocado")] Reuniao reuniao)
        {
            if (id != reuniao.ReuniaoId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(reuniao);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ReuniaoExists(reuniao.ReuniaoId))
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
            ViewData["AtaId"] = new SelectList(_context.AtaReuniao, "AtaId", "Descricao", reuniao.AtaId);
            ViewData["HoraId"] = new SelectList(_context.Hora, "HoraId", "UtilizadorId", reuniao.HoraId);
            return View(reuniao);
        }

        // GET: Reunioes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reuniao = await _context.Reuniao
                .Include(r => r.Ata)
                .Include(r => r.Hora)
                .FirstOrDefaultAsync(m => m.ReuniaoId == id);
            if (reuniao == null)
            {
                return NotFound();
            }

            return View(reuniao);
        }

        // POST: Reunioes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var reuniao = await _context.Reuniao.FindAsync(id);
            _context.Reuniao.Remove(reuniao);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ReuniaoExists(int id)
        {
            return _context.Reuniao.Any(e => e.ReuniaoId == id);
        }
    }
}
