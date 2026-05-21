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
        {
            return NotFound();
        }

        var ambienteImagem = await _context.AmbienteImagens
            .FirstOrDefaultAsync(m => m.Id == id);
        if (ambienteImagem == null)
        {
            return NotFound();
        }

        return View(ambienteImagem);
    }

    // GET: NossoAmbiente/Create
    public IActionResult Create()
    {
        return View();
    }

    // POST: NossoAmbiente/Create
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("Id,CaminhoImagem,Ordem,Ativo")] AmbienteImagem ambienteImagem)
    {
        if (ModelState.IsValid)
        {
            _context.Add(ambienteImagem);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(ambienteImagem);
    }

    // GET: NossoAmbiente/Edit/5
    public async Task<IActionResult> Edit(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var ambienteImagem = await _context.AmbienteImagens.FindAsync(id);
        if (ambienteImagem == null)
        {
            return NotFound();
        }
        return View(ambienteImagem);
    }

    // POST: NossoAmbiente/Edit/5
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int id, [Bind("Id,CaminhoImagem,Ordem,Ativo")] AmbienteImagem ambienteImagem)
    {
        if (id != ambienteImagem.Id)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            try
            {
                _context.Update(ambienteImagem);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AmbienteImagemExists(ambienteImagem.Id))
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
        return View(ambienteImagem);
    }

    // GET: NossoAmbiente/Delete/5
    public async Task<IActionResult> Delete(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var ambienteImagem = await _context.AmbienteImagens
            .FirstOrDefaultAsync(m => m.Id == id);
        if (ambienteImagem == null)
        {
            return NotFound();
        }

        return View(ambienteImagem);
    }

    // POST: NossoAmbiente/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        var ambienteImagem = await _context.AmbienteImagens.FindAsync(id);
        if (ambienteImagem != null)
        {
            _context.AmbienteImagens.Remove(ambienteImagem);
        }

        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    private bool AmbienteImagemExists(int id)
    {
        return _context.AmbienteImagens.Any(e => e.Id == id);
    }
}
