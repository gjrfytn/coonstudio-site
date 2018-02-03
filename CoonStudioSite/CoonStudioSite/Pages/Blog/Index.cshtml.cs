using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CoonGamesSite.Models;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CoonStudioSite.Pages.Blog
{
    public class IndexModel : PageModel
    {
        private readonly CoonStudioSiteContext _context;

        public IndexModel(CoonStudioSiteContext context)
        {
            _context = context;
        }

        public IList<BlogEntry> BlogEntries { get; set; }
        public SelectList EntryTags { get; set; }
        public string EntryTag { get; set; }

        public async Task OnGetAsync(string entryTag, string searchString)
        {
            var entryTags = _context.BlogEntries.Where(e=>!string.IsNullOrEmpty(e.Tag)).Select(e=>e.Tag).OrderBy(t=>t);

            EntryTags =new SelectList(entryTags);

            var blogEntries = _context.BlogEntries.AsQueryable();

            if (!string.IsNullOrEmpty(entryTag))
            {
                blogEntries = blogEntries.Where(e => e.Tag == entryTag);
            }

            if (!string.IsNullOrEmpty(searchString))
            {
                blogEntries = blogEntries.Where(s => s.Title.Contains(searchString));
            }
            
            BlogEntries = await blogEntries.ToListAsync();
        }
    }
}
