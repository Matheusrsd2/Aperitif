using Aperitif.DataAccess.Data;
using Aperitif.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Aperitif.Pages.Categorias
{
    public class DeleteModel : PageModel
    {
        public Categoria Categoria { get; set; }
        public readonly AppDbContext _context;
        public DeleteModel(AppDbContext context)
        {
            _context = context;
        }
        public void OnGet(int id)
        {
            Categoria = _context.Categorias.Find(id);
        }

        public async Task<IActionResult> OnPost(Categoria categoria)
        {
            var categoriaFromDb = _context.Categorias.Find(categoria.Id);

            _context.Categorias.Remove(categoriaFromDb);
            await _context.SaveChangesAsync();
            TempData["sucesso"] = "Categoria removida com sucesso!";
            return RedirectToPage("Index");

        } 
    }
}
