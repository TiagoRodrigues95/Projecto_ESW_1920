using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CandidaturaEmais.Data;
using CandidaturaEmais.Models;
using System.IO;
using Microsoft.AspNetCore.Http;

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
            var applicationDbContext = _context.PFC.Include(p => p.Docente).Include(p => p.Aluno);
            return View(await applicationDbContext.ToListAsync());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult Index(IFormFile postedFile)
        {
            if (postedFile != null)
            {
                try
                {
                    string fileExtension = Path.GetExtension(postedFile.FileName);

                    //Validate uploaded file and return error.
                    if (fileExtension != ".csv")
                    {
                        ViewBag.Message = "Please select the csv file with .csv extension";
                        return View();
                    }


                    var pfc = new List<PFC>();
                    using (var sreader = new StreamReader(postedFile.OpenReadStream()))
                    {
                        //First line is header. If header is not passed in csv then we can neglect the below line.
                        string[] headers = sreader.ReadLine().Split(';');
                        //Loop through the records
                        while (!sreader.EndOfStream)
                        {
                            string[] rows = sreader.ReadLine().Split(';');

                            pfc.Add(new PFC
                            {
                                PFCId = int.Parse(rows[0].ToString()),
                                Timestamp = DateTime.Parse(rows[1].ToString()),
                                PropostaUrl = rows[2].ToString(),
                                DocenteId = rows[3].ToString(),
                                AlunoId = rows[3].ToString()
                            });
                        }
                    }

                    
                    return RedirectToAction("Index", pfc);
                }
                catch (Exception ex)
                {
                    ViewBag.Message = ex.Message;
                }
            }
            else
            {
                ViewBag.Message = "Please select the file first to upload.";
            }
            return View("Index");
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
            var UtilizadorDocente = _context.Users.Where(m => !m.UserName.Equals(User.Identity.Name)).ToArray();
            var UtilizadorAluno = _context.Users.Where(m => !m.UserName.Equals(User.Identity.Name)).ToArray();

            ViewData["DocenteId"] = new SelectList(UtilizadorDocente, "Id", "Nome");
            ViewData["AlunoId"] = new SelectList(UtilizadorAluno, "Id", "Nome");

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

            var UtilizadorDocente = _context.Users.Where(m => !m.UserName.Equals(User.Identity.Name)).ToArray();
            var UtilizadorAluno = _context.Users.Where(m => !m.UserName.Equals(User.Identity.Name)).ToArray();

            ViewData["DocenteId"] = new SelectList(UtilizadorDocente, "Id", "Nome", pFC.DocenteId);
            ViewData["AlunoId"] = new SelectList(UtilizadorAluno, "Id", "Nome", pFC.AlunoId);

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

            var UtilizadorDocente = _context.Users.Where(m => !m.UserName.Equals(User.Identity.Name)).ToArray();
            var UtilizadorAluno = _context.Users.Where(m => !m.UserName.Equals(User.Identity.Name)).ToArray();

            ViewData["DocenteId"] = new SelectList(UtilizadorDocente, "Id", "Nome", pFC.DocenteId);
            ViewData["AlunoId"] = new SelectList(UtilizadorAluno, "Id", "Nome", pFC.AlunoId);

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

            var UtilizadorDocente = _context.Users.Where(m => !m.UserName.Equals(User.Identity.Name)).ToArray();
            var UtilizadorAluno = _context.Users.Where(m => !m.UserName.Equals(User.Identity.Name)).ToArray();
            
            ViewData["DocenteId"] = new SelectList(UtilizadorDocente, "Id", "Nome", pFC.DocenteId);
            ViewData["AlunoId"] = new SelectList(UtilizadorAluno, "Id", "Nome", pFC.AlunoId);
            
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
