using ContentManagementSystem.Data.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace ContentManagementSystem.Pages.CMS.AllText
{
    public class EditModel : PageModel
    {
        private readonly ContentManagementSystem.Data.WebsiteContentContext _context;

        public EditModel(ContentManagementSystem.Data.WebsiteContentContext context)
        {
            _context = context;
        }

        [BindProperty]
        public TextContent TextContent { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            TextContent = await _context.TextsContent.FirstOrDefaultAsync(m => m.Id == id);

            if (TextContent == null)
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

            _context.Attach(TextContent).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TextContentExists(TextContent.Id))
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

        private bool TextContentExists(int id)
        {
            return _context.TextsContent.Any(e => e.Id == id);
        }
    }
}