using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Vereda_Cafeteria.Data;
using Vereda_Cafeteria.Models;

namespace Vereda_Cafeteria.Controllers
{
    [Authorize]
    [Route("admin/evento/[action]")]
    public class EventoController : Controller
    {
        private readonly AppDbContext _context;

        public EventoController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Evento
        public async Task<IActionResult> Index()
        {
            return View(await _context.Eventos.ToListAsync());
        }

        // GET: Evento/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var evento = await _context.Eventos
                .FirstOrDefaultAsync(m => m.EventoId == id);
            if (evento == null)
            {
                return NotFound();
            }

            return View(evento);
        }

        // GET: Evento/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Evento/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("EventoId,Titulo,Descricao,ImagemUrl,CorFundo")] Evento evento, IFormFile imagemArquivo)
        {
            if (imagemArquivo != null && imagemArquivo.Length > 0)
            {
                var nomeArquivo = Path.GetFileName(imagemArquivo.FileName);
                var pasta = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "img", "Eventos");

                if (!Directory.Exists(pasta))
                    Directory.CreateDirectory(pasta);

                var caminhoCompleto = Path.Combine(pasta, nomeArquivo);

                using (var stream = new FileStream(caminhoCompleto, FileMode.Create))
                    await imagemArquivo.CopyToAsync(stream);

                evento.ImagemUrl = "/img/Eventos/" + nomeArquivo;
            }

            ModelState.Remove("ImagemUrl");

            if (ModelState.IsValid)
            {
                _context.Add(evento);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(evento);
        }

        // GET: Evento/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var evento = await _context.Eventos.FindAsync(id);
            if (evento == null)
            {
                return NotFound();
            }
            return View(evento);
        }

        // POST: Evento/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(
    [Bind("EventoId,Titulo,Descricao,ImagemUrl,CorFundo")] Evento evento, IFormFile imagemArquivo)
        {
            if (imagemArquivo != null && imagemArquivo.Length > 0)
            {
                var nomeArquivo = Path.GetFileName(imagemArquivo.FileName);
                var pasta = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "img", "Eventos");

                if (!Directory.Exists(pasta))
                    Directory.CreateDirectory(pasta);

                var caminhoCompleto = Path.Combine(pasta, nomeArquivo);

                using (var stream = new FileStream(caminhoCompleto, FileMode.Create))
                    await imagemArquivo.CopyToAsync(stream);

                evento.ImagemUrl = "/img/Eventos/" + nomeArquivo;
            }

            ModelState.Remove("ImagemUrl");

            if (!ModelState.IsValid)
            {
                foreach (var erro in ModelState.Values.SelectMany(v => v.Errors))
                {
                    Console.WriteLine(erro.ErrorMessage);
                }

                return View(evento);
            }

            _context.Update(evento);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }

        // GET: Evento/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var evento = await _context.Eventos
                .FirstOrDefaultAsync(m => m.EventoId == id);
            if (evento == null)
            {
                return NotFound();
            }

            return View(evento);
        }



        // POST: Evento/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int EventoId)
        {
            var evento = await _context.Eventos.FindAsync(EventoId);
            if (evento != null)
            {
                _context.Eventos.Remove(evento);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Index));
        }

        private bool EventoExists(int id)
        {
            return _context.Eventos.Any(e => e.EventoId == id);
        }
    }
}
