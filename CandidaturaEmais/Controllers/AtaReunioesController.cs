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
    public class AtaReunioesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AtaReunioesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: AtaReunioes
        public async Task<IActionResult> Index()
        {
            return View(await _context.AtaReuniao.ToListAsync());
        }

        // GET: AtaReunioes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ataReuniao = await _context.AtaReuniao
                .FirstOrDefaultAsync(m => m.AtaId == id);
            if (ataReuniao == null)
            {
                return NotFound();
            }

            return View(ataReuniao);
        }

        // GET: AtaReunioes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: AtaReunioes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("AtaId,Timestamp,Titulo,Descricao")] AtaReuniao ataReuniao)
        {
            if (ModelState.IsValid)
            {
                _context.Add(ataReuniao);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(ataReuniao);
        }

        // GET: AtaReunioes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ataReuniao = await _context.AtaReuniao.FindAsync(id);
            if (ataReuniao == null)
            {
                return NotFound();
            }
            return View(ataReuniao);
        }

        // POST: AtaReunioes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("AtaId,Timestamp,Titulo,Descricao")] AtaReuniao ataReuniao)
        {
            if (id != ataReuniao.AtaId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(ataReuniao);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AtaReuniaoExists(ataReuniao.AtaId))
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
            return View(ataReuniao);
        }

        // GET: AtaReunioes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ataReuniao = await _context.AtaReuniao
                .FirstOrDefaultAsync(m => m.AtaId == id);
            if (ataReuniao == null)
            {
                return NotFound();
            }

            return View(ataReuniao);
        }

        // POST: AtaReunioes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var ataReuniao = await _context.AtaReuniao.FindAsync(id);
            _context.AtaReuniao.Remove(ataReuniao);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AtaReuniaoExists(int id)
        {
            return _context.AtaReuniao.Any(e => e.AtaId == id);
        }
    }
}
