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
    public class MensagemConversasController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MensagemConversasController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: MensagemConversas
        public async Task<IActionResult> Index()
        {
            return View(await _context.MensagemConversa.ToListAsync());
        }

        // GET: MensagemConversas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mensagemConversa = await _context.MensagemConversa
                .FirstOrDefaultAsync(m => m.MensagemId == id);
            if (mensagemConversa == null)
            {
                return NotFound();
            }

            return View(mensagemConversa);
        }

        // GET: MensagemConversas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: MensagemConversas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MensagemId,UtilizadorId,utilizador2Id")] MensagemConversa mensagemConversa)
        {
            if (ModelState.IsValid)
            {
                _context.Add(mensagemConversa);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(mensagemConversa);
        }

        // GET: MensagemConversas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mensagemConversa = await _context.MensagemConversa.FindAsync(id);
            if (mensagemConversa == null)
            {
                return NotFound();
            }
            return View(mensagemConversa);
        }

        // POST: MensagemConversas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MensagemId,UtilizadorId,utilizador2Id")] MensagemConversa mensagemConversa)
        {
            if (id != mensagemConversa.MensagemId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(mensagemConversa);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MensagemConversaExists(mensagemConversa.MensagemId))
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
            return View(mensagemConversa);
        }

        // GET: MensagemConversas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mensagemConversa = await _context.MensagemConversa
                .FirstOrDefaultAsync(m => m.MensagemId == id);
            if (mensagemConversa == null)
            {
                return NotFound();
            }

            return View(mensagemConversa);
        }

        // POST: MensagemConversas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var mensagemConversa = await _context.MensagemConversa.FindAsync(id);
            _context.MensagemConversa.Remove(mensagemConversa);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MensagemConversaExists(int id)
        {
            return _context.MensagemConversa.Any(e => e.MensagemId == id);
        }
    }
}
