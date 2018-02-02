using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
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

        public IList<BlogEntry> BlogEntry { get;set; }

        public async Task OnGetAsync()
        {
            BlogEntry = await _context.BlogEntries.ToListAsync();
        }
    }
}
