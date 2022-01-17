using Aperitif.DataAccess.Data;
using Aperitif.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Aperitif.Pages.Admin.Categorias
{
    public class IndexModel : PageModel
    {
        private readonly AppDbContext _context;

        public IEnumerable<Categoria> Categorias { get; set; }
        public IndexModel(AppDbContext context)
        {
            _context = context;
        }
        public void OnGet()
        {
            Categorias = _context.Categorias.ToList();
        }
    }
}
