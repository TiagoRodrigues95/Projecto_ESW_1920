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
    public class InqueritoRespostasController : Controller
    {
        private readonly ApplicationDbContext _context;

        public InqueritoRespostasController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: InqueritoRespostas
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.InqueritoResposta.Include(i => i.Aluno).Include(i => i.Inquerito);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: InqueritoRespostas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var inqueritoResposta = await _context.InqueritoResposta
                .Include(i => i.Aluno)
                .Include(i => i.Inquerito)
                .FirstOrDefaultAsync(m => m.InqueritoRespostaId == id);
            if (inqueritoResposta == null)
            {
                return NotFound();
            }

            return View(inqueritoResposta);
        }

        // GET: InqueritoRespostas/Create
        public IActionResult Create()
        {
            ViewData["AlunoId"] = new SelectList(_context.Users, "Id", "Id");
            ViewData["InqueritoId"] = new SelectList(_context.Inquerito, "InqueritoId", "InqueritoId");
            return View();
        }

        // POST: InqueritoRespostas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("InqueritoRespostaId,Data,AnoLetivo,Url,InqueritoId,AlunoId")] InqueritoResposta inqueritoResposta)
        {
            if (ModelState.IsValid)
            {
                _context.Add(inqueritoResposta);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["AlunoId"] = new SelectList(_context.Users, "Id", "Id", inqueritoResposta.AlunoId);
            ViewData["InqueritoId"] = new SelectList(_context.Inquerito, "InqueritoId", "InqueritoId", inqueritoResposta.InqueritoId);
            return View(inqueritoResposta);
        }

        // GET: InqueritoRespostas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var inqueritoResposta = await _context.InqueritoResposta.FindAsync(id);
            if (inqueritoResposta == null)
            {
                return NotFound();
            }
            ViewData["AlunoId"] = new SelectList(_context.Users, "Id", "Id", inqueritoResposta.AlunoId);
            ViewData["InqueritoId"] = new SelectList(_context.Inquerito, "InqueritoId", "InqueritoId", inqueritoResposta.InqueritoId);
            return View(inqueritoResposta);
        }

        // POST: InqueritoRespostas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("InqueritoRespostaId,Data,AnoLetivo,Url,InqueritoId,AlunoId")] InqueritoResposta inqueritoResposta)
        {
            if (id != inqueritoResposta.InqueritoRespostaId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(inqueritoResposta);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!InqueritoRespostaExists(inqueritoResposta.InqueritoRespostaId))
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
            ViewData["AlunoId"] = new SelectList(_context.Users, "Id", "Id", inqueritoResposta.AlunoId);
            ViewData["InqueritoId"] = new SelectList(_context.Inquerito, "InqueritoId", "InqueritoId", inqueritoResposta.InqueritoId);
            return View(inqueritoResposta);
        }

        // GET: InqueritoRespostas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var inqueritoResposta = await _context.InqueritoResposta
                .Include(i => i.Aluno)
                .Include(i => i.Inquerito)
                .FirstOrDefaultAsync(m => m.InqueritoRespostaId == id);
            if (inqueritoResposta == null)
            {
                return NotFound();
            }

            return View(inqueritoResposta);
        }

        // POST: InqueritoRespostas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var inqueritoResposta = await _context.InqueritoResposta.FindAsync(id);
            _context.InqueritoResposta.Remove(inqueritoResposta);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool InqueritoRespostaExists(int id)
        {
            return _context.InqueritoResposta.Any(e => e.InqueritoRespostaId == id);
        }
    }
}
