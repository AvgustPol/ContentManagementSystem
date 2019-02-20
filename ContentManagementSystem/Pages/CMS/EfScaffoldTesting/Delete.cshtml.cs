using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ContentManagementSystem.Data;
using ContentManagementSystem.Data.Entities;

namespace ContentManagementSystem.Pages.CMS.EfScaffoldTesting
{
    public class DeleteModel : PageModel
    {
        private readonly ContentManagementSystem.Data.WebsiteContentContext _context;

        public DeleteModel(ContentManagementSystem.Data.WebsiteContentContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Image ImageContent { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ImageContent = await _context.ImageContent.FirstOrDefaultAsync(m => m.Id == id);

            if (ImageContent == null)
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

            ImageContent = await _context.ImageContent.FindAsync(id);

            if (ImageContent != null)
            {
                _context.ImageContent.Remove(ImageContent);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
