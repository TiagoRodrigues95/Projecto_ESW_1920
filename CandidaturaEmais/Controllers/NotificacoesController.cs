using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CandidaturaEmais.Data;

namespace CandidaturaEmais.Controllers
{
    public class NotificacoesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public NotificacoesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Notificacoes
        public async Task<IActionResult> Index()
        {
            return View(await _context.Notificacao.ToListAsync());
        }

        // GET: Notificacoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var notificacao = await _context.Notificacao
                .FirstOrDefaultAsync(m => m.NotificacaoId == id);
            if (notificacao == null)
            {
                return NotFound();
            }

            return View(notificacao);
        }
    }
}