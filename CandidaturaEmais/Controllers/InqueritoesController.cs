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
    public class InqueritoesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public InqueritoesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Inqueritoes
        public async Task<IActionResult> Index()
        {
            return View(await _context.Inquerito.ToListAsync());
        }

        // GET: Inqueritoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var inquerito = await _context.Inquerito
                .FirstOrDefaultAsync(m => m.InqueritoId == id);
            if (inquerito == null)
            {
                return NotFound();
            }

            return View(inquerito);
        }

        // GET: Inqueritoes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Inqueritoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("InqueritoId,Data,AnoLetivo,Url")] Inquerito inquerito)
        {
            if (ModelState.IsValid)
            {
                _context.Add(inquerito);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(inquerito);
        }

        // GET: Inqueritoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var inquerito = await _context.Inquerito.FindAsync(id);
            if (inquerito == null)
            {
                return NotFound();
            }
            return View(inquerito);
        }

        // POST: Inqueritoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("InqueritoId,Data,AnoLetivo,Url")] Inquerito inquerito)
        {
            if (id != inquerito.InqueritoId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(inquerito);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!InqueritoExists(inquerito.InqueritoId))
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
            return View(inquerito);
        }

        // GET: Inqueritoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var inquerito = await _context.Inquerito
                .FirstOrDefaultAsync(m => m.InqueritoId == id);
            if (inquerito == null)
            {
                return NotFound();
            }

            return View(inquerito);
        }

        // POST: Inqueritoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var inquerito = await _context.Inquerito.FindAsync(id);
            _context.Inquerito.Remove(inquerito);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool InqueritoExists(int id)
        {
            return _context.Inquerito.Any(e => e.InqueritoId == id);
        }
    }
}
