﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using CoonGamesSite.Models;

namespace CoonStudioSite.Pages.Blog
{
    public class CreateModel : PageModel
    {
        private readonly CoonGamesSite.Models.CoonStudioSiteContext _context;

        public CreateModel(CoonGamesSite.Models.CoonStudioSiteContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public BlogEntry BlogEntry { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.BlogEntries.Add(BlogEntry);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}