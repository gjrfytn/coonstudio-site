using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CoonGamesSite.Models;

namespace CoonStudioSite.Pages.Blog
{
    public class DeleteModel : PageModel
    {
        private readonly CoonGamesSite.Models.CoonStudioSiteContext _context;

        public DeleteModel(CoonGamesSite.Models.CoonStudioSiteContext context)
        {
            _context = context;
        }

        [BindProperty]
        public BlogEntry BlogEntry { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            BlogEntry = await _context.BlogEntries.SingleOrDefaultAsync(m => m.ID == id);

            if (BlogEntry == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            BlogEntry = await _context.BlogEntries.FindAsync(id);

            if (BlogEntry != null)
            {
                _context.BlogEntries.Remove(BlogEntry);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
