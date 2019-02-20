using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ContentManagementSystem.Data;
using ContentManagementSystem.Data.Entities;

namespace ContentManagementSystem.Pages.CMS.EfScaffoldTesting
{
    public class CreateModel : PageModel
    {
        private readonly ContentManagementSystem.Data.WebsiteContentContext _context;

        public CreateModel(ContentManagementSystem.Data.WebsiteContentContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Image ImageContent { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.ImageContent.Add(ImageContent);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}