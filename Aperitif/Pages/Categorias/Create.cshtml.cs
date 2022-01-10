using Aperitif.DataAccess.Data;
using Aperitif.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Aperitif.Pages.Categorias
{
    public class CreateModel : PageModel
    {
        public Categoria Categoria { get; set; }
        public readonly AppDbContext _context;
        public CreateModel(AppDbContext context)
        {
            _context = context;
        }
        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPost(Categoria categoria)
        {
            if(categoria.Nome == categoria.DisplayOrder.ToString())
            {
                ModelState.AddModelError(string.Empty, "Error");
            }
            if (ModelState.IsValid)
            {
                await _context.Categorias.AddAsync(categoria);
                await _context.SaveChangesAsync();
                TempData["sucesso"] = "Categoria criada com sucesso!";
                return RedirectToPage("Index");
            }
            return Page();
            
        } 
    }
}
