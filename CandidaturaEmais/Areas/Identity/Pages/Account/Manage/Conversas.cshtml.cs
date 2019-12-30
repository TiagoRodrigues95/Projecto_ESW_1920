using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CandidaturaEmais.Data;
using CandidaturaEmais.Models;

namespace CandidaturaEmais
{
    public class ConversasModel : PageModel
    {
        private readonly CandidaturaEmais.Data.ApplicationDbContext _context;

        public ConversasModel(CandidaturaEmais.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<MensagemConversa> MensagemConversa { get;set; }

        public async Task OnGetAsync()
        {
            MensagemConversa = await _context.MensagemConversa.ToListAsync();
        }
    }
}
