using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ContentManagementSystem.Data;
using ContentManagementSystem.Data.Entities;

namespace ContentManagementSystem.Pages.CMS.EfScaffoldTesting
{
    public class EditModel : PageModel
    {
        private readonly ContentManagementSystem.Data.WebsiteContentContext _context;

        public EditModel(ContentManagementSystem.Data.WebsiteContentContext context)
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

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(ImageContent).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ImageContentExists(ImageContent.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool ImageContentExists(int id)
        {
            return _context.ImageContent.Any(e => e.Id == id);
        }
    }
}
