using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Vereda_Cafeteria.Data;
using Vereda_Cafeteria.Models;

namespace Vereda_Cafeteria.Controllers
{
    [Authorize]
    [Route("Admin/ProdutoMenu/[action]")]
    public class ProdutoMenuController : Controller
    {
        private readonly AppDbContext _context;

        // IDs das categorias que pertencem ao Menu (Cardápio)
        private static readonly int[] CategoriasMenu = { 1, 2, 3, 4, 5 };

        public ProdutoMenuController(AppDbContext context)
        {
            _context = context;
        }

        // GET: ProdutoMenu
        public async Task<IActionResult> Index()
        {
            var produtos = await _context.Produtos
                .Include(p => p.Categoria)
                .Where(p => CategoriasMenu.Contains(p.CategoriaId))
                .OrderBy(p => p.CategoriaId)
                .ThenBy(p => p.Nome)
                .ToListAsync();

            return View(produtos);
        }

        // GET: ProdutoMenu/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
                return NotFound();

            var produto = await _context.Produtos
                .Include(p => p.Categoria)
                .FirstOrDefaultAsync(m => m.ProdutoId == id);

            if (produto == null)
                return NotFound();

            return View(produto);
        }

        // GET: ProdutoMenu/Create
        public IActionResult Create()
        {
            ViewData["CategoriaId"] = new SelectList(_context.Categorias.Where(c => CategoriasMenu.Contains(c.CategoriaId)), "CategoriaId", "Nome");
            return View();
        }

        // POST: ProdutoMenu/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ProdutoId,CategoriaId,Nome,Descricao,QtdEstoque,Preco,Ativo")] Produto produto, IFormFile imagemArquivo)
        {
            if (imagemArquivo != null && imagemArquivo.Length > 0)
            {
                var nomeArquivo = Path.GetFileName(imagemArquivo.FileName);
                var pasta = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "img", "Produtos");

                if (!Directory.Exists(pasta))
                    Directory.CreateDirectory(pasta);

                var caminhoCompleto = Path.Combine(pasta, nomeArquivo);

                using (var stream = new FileStream(caminhoCompleto, FileMode.Create))
                    await imagemArquivo.CopyToAsync(stream);

                produto.ImagemUrl = "/img/Produtos/" + nomeArquivo;
            }

            ModelState.Remove("ImagemUrl");

            if (ModelState.IsValid)
            {
                _context.Add(produto);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            ViewData["CategoriaId"] = new SelectList(_context.Categorias.Where(c => CategoriasMenu.Contains(c.CategoriaId)), "CategoriaId", "Nome", produto.CategoriaId);
            return View(produto);
        }

        // GET: ProdutoMenu/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
                return NotFound();

            var produto = await _context.Produtos.FindAsync(id);

            if (produto == null)
                return NotFound();

            ViewData["CategoriaId"] = new SelectList(_context.Categorias.Where(c => CategoriasMenu.Contains(c.CategoriaId)), "CategoriaId", "Nome", produto.CategoriaId);
            return View(produto);
        }

        // POST: ProdutoMenu/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ProdutoId,CategoriaId,Nome,Descricao,QtdEstoque,Preco,Ativo")] Produto produto, IFormFile imagemArquivo)
        {
            if (id != produto.ProdutoId)
                return NotFound();

            if (imagemArquivo != null && imagemArquivo.Length > 0)
            {
                var nomeArquivo = Path.GetFileName(imagemArquivo.FileName);
                var pasta = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "img", "Produtos");

                if (!Directory.Exists(pasta))
                    Directory.CreateDirectory(pasta);

                var caminhoCompleto = Path.Combine(pasta, nomeArquivo);

                using (var stream = new FileStream(caminhoCompleto, FileMode.Create))
                    await imagemArquivo.CopyToAsync(stream);

                produto.ImagemUrl = "/img/Produtos/" + nomeArquivo;
            }
            else
            {
                // Mantém a imagem já salva se nenhuma nova for enviada
                var existente = await _context.Produtos.AsNoTracking()
                    .FirstOrDefaultAsync(p => p.ProdutoId == id);

                if (existente != null)
                    produto.ImagemUrl = existente.ImagemUrl;
            }

            ModelState.Remove("ImagemUrl");

            foreach (var erro in ModelState)
            {
                foreach (var e in erro.Value.Errors)
                {
                    Console.WriteLine($"{erro.Key}: {e.ErrorMessage}");
                }
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(produto);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProdutoExists(produto.ProdutoId))
                        return NotFound();
                    else
                        throw;
                }

                Console.WriteLine("CHEGOU NO REDIRECT");

                return Redirect("/Admin/ProdutoMenu/Index");
            }

            ViewData["CategoriaId"] = new SelectList(_context.Categorias.Where(c => CategoriasMenu.Contains(c.CategoriaId)), "CategoriaId", "Nome", produto.CategoriaId);
            return View(produto);
        }

        // GET: ProdutoMenu/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
                return NotFound();

            var produto = await _context.Produtos
                .Include(p => p.Categoria)
                .FirstOrDefaultAsync(m => m.ProdutoId == id);

            if (produto == null)
                return NotFound();

            return View(produto);
        }

        // POST: ProdutoMenu/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int ProdutoId)
        {
            var produto = await _context.Produtos.FindAsync(ProdutoId);

            if (produto != null)
            {
                _context.Produtos.Remove(produto);
                await _context.SaveChangesAsync();
            }

            return RedirectToAction(nameof(Index));
        }
        private bool ProdutoExists(int id)
        {
            return _context.Produtos.Any(e => e.ProdutoId == id);
        }
    }

}