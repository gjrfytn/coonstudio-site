using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CoonGamesSite.Models;

namespace CoonStudioSite.Pages.Blog
{
    public class IndexModel : PageModel
    {
        private readonly CoonGamesSite.Models.CoonStudioSiteContext _context;

        public IndexModel(CoonGamesSite.Models.CoonStudioSiteContext context)
        {
            _context = context;
        }

        public IList<BlogEntry> BlogEntries { get; set; }

        public async Task OnGetAsync()
        {
            BlogEntries = await _context.BlogEntries.ToListAsync();
        }
    }
}
