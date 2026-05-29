using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Vereda_Cafeteria.Data;
using Vereda_Cafeteria.Models;
using Microsoft.AspNetCore.Authorization;

namespace Vereda_Cafeteria.Controllers;

[Authorize]
[Route("Admin/NossoAmbiente/[action]")]
public class NossoAmbienteController : Controller
{
    private readonly AppDbContext _context;

    public NossoAmbienteController(AppDbContext context)
    {
        _context = context;
    }

    // GET: NossoAmbiente
    public async Task<IActionResult> Index()
    {
        return View(await _context.AmbienteImagens.ToListAsync());
    }

    // GET: NossoAmbiente/Details/5
    public async Task<IActionResult> Details(int? id)
    {
        if (id == null)
            return NotFound();

        var ambienteImagem = await _context.AmbienteImagens
            .FirstOrDefaultAsync(m => m.Id == id);

        if (ambienteImagem == null)
            return NotFound();

        return View(ambienteImagem);
    }

    // GET: NossoAmbiente/Create
    public IActionResult Create()
    {
        return View();
    }

    // POST: NossoAmbiente/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(AmbienteImagem model, IFormFile imagemArquivo)
    {
        if (imagemArquivo != null && imagemArquivo.Length > 0)
        {
            var nomeArquivo = Path.GetFileName(imagemArquivo.FileName);
            var pasta = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "img", "NossoAmbiente");

            if (!Directory.Exists(pasta))
                Directory.CreateDirectory(pasta);

            var caminhoCompleto = Path.Combine(pasta, nomeArquivo);

            using (var stream = new FileStream(caminhoCompleto, FileMode.Create))
                await imagemArquivo.CopyToAsync(stream);

            model.CaminhoImagem = "/img/NossoAmbiente/" + nomeArquivo;
        }

        // Remove CaminhoImagem do ModelState para não bloquear quando vem do upload
        ModelState.Remove("CaminhoImagem");

        if (ModelState.IsValid)
        {
            _context.Add(model);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        return View(model);
    }

    // GET: NossoAmbiente/Edit/5
    public async Task<IActionResult> Edit(int? id)
    {
        if (id == null)
            return NotFound();

        var ambienteImagem = await _context.AmbienteImagens.FindAsync(id);

        if (ambienteImagem == null)
            return NotFound();

        return View(ambienteImagem);
    }

    // POST: NossoAmbiente/Edit/5
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int id, AmbienteImagem model, IFormFile imagemArquivo)
    {
        if (id != model.Id)
            return NotFound();

        if (imagemArquivo != null && imagemArquivo.Length > 0)
        {
            var nomeArquivo = Path.GetFileName(imagemArquivo.FileName);
            var pasta = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "img", "NossoAmbiente");

            if (!Directory.Exists(pasta))
                Directory.CreateDirectory(pasta);

            var caminhoCompleto = Path.Combine(pasta, nomeArquivo);

            using (var stream = new FileStream(caminhoCompleto, FileMode.Create))
                await imagemArquivo.CopyToAsync(stream);

            model.CaminhoImagem = "/img/NossoAmbiente/" + nomeArquivo;
        }
        else
        {
            // Mantém o caminho já salvo no banco se nenhuma imagem nova for enviada
            var existente = await _context.AmbienteImagens.AsNoTracking()
                .FirstOrDefaultAsync(x => x.Id == id);

            if (existente != null)
                model.CaminhoImagem = existente.CaminhoImagem;
        }

        ModelState.Remove("CaminhoImagem");

        if (ModelState.IsValid)
        {
            try
            {
                _context.Update(model);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AmbienteImagemExists(model.Id))
                    return NotFound();
                else
                    throw;
            }

            return RedirectToAction(nameof(Index));
        }

        return View(model);
    }

    // GET: NossoAmbiente/Delete/5
    public async Task<IActionResult> Delete(int? id)
    {
        if (id == null)
            return NotFound();

        var ambienteImagem = await _context.AmbienteImagens
            .FirstOrDefaultAsync(m => m.Id == id);

        if (ambienteImagem == null)
            return NotFound();

        return View(ambienteImagem);
    }

    // POST: NossoAmbiente/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        var ambienteImagem = await _context.AmbienteImagens.FindAsync(id);

        if (ambienteImagem != null)
            _context.AmbienteImagens.Remove(ambienteImagem);

        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    private bool AmbienteImagemExists(int id)
    {
        return _context.AmbienteImagens.Any(e => e.Id == id);
    }
}