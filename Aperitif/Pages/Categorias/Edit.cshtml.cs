using Aperitif.Data;
using Aperitif.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Aperitif.Pages.Categorias
{
    public class EditModel : PageModel
    {
        public Categoria Categoria { get; set; }
        public readonly AppDbContext _context;
        public EditModel(AppDbContext context)
        {
            _context = context;
        }
        public void OnGet(int id)
        {
            Categoria = _context.Categorias.Find(id);
        }

        public async Task<IActionResult> OnPost(Categoria categoria)
        {
            if(categoria.Nome == categoria.DisplayOrder.ToString())
            {
                ModelState.AddModelError(string.Empty, "Error");
            }
            if (ModelState.IsValid)
            {
                _context.Categorias.Update(categoria);
                await _context.SaveChangesAsync();
                return RedirectToPage("Index");
            }
            return Page();
            
        } 
    }
}
