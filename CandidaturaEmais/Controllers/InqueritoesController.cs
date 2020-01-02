using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CandidaturaEmais.Data;
using CandidaturaEmais.Models;
using CandidaturaEmais.ViewModels;

namespace CandidaturaEmais.Controllers
{
    public class InqueritoesController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IHostingEnvironment hostingEnvironment;

        public InqueritoesController(ApplicationDbContext context, IHostingEnvironment hostingEnvironment)
        {
            _context = context;
            this.hostingEnvironment = hostingEnvironment;
        }

        // GET: Inqueritoes
        public async Task<IActionResult> Index(string searchString)
        {
            var inquerito = from m in _context.Inquerito
                            select m;

            if (!String.IsNullOrEmpty(searchString))
            {
                inquerito = inquerito.Where(s => s.AnoLetivo.Contains(searchString));
            }

            return View(await inquerito.ToListAsync());
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
        public async Task<IActionResult> Create(Inquerito_viewmodel Inquerito_viewmodel)
        {
            if (ModelState.IsValid)
            {

                string uniqueFileName = null;

                // If the Photo property on the incoming model object is not null, then the user
                // has selected an image to upload.
                if (Inquerito_viewmodel.Url != null && Inquerito_viewmodel.Url.Count > 0)
                {
                    // Loop thru each selected file
                    foreach (ViewModels.IFormFile url in Inquerito_viewmodel.Url)
                    {
                        // The image must be uploaded to the images folder in wwwroot
                        // To get the path of the wwwroot folder we are using the inject
                        // HostingEnvironment service provided by ASP.NET Core
                        string uploadsFolder = Path.Combine(hostingEnvironment.WebRootPath, "ficheiros");
                        // To make sure the file name is unique we are appending a new
                        // GUID value and and an underscore to the file name
                        uniqueFileName = Guid.NewGuid().ToString() + "_" + url.FileName;
                        string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                        // Use CopyTo() method provided by IFormFile interface to
                        // copy the file to wwwroot/images folder
                        url.CopyTo(new FileStream(filePath, FileMode.Create));
                    }
                }

                Inquerito newInquerito = new Inquerito
                {
                    Data = Inquerito_viewmodel.Data,
                    AnoLetivo = Inquerito_viewmodel.AnoLetivo,
                    // Store the file name in PhotoPath property of the employee object
                    // which gets saved to the Employees database table
                    Url = uniqueFileName
                };

                _context.Add(newInquerito);
                //_context.Add(inquerito);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index", new { id = newInquerito.InqueritoId });
            }
            return View();
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

