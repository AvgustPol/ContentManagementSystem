using ContentManagementSystem.Data.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace ContentManagementSystem.Pages.CMS.AllText
{
    public class DeleteModel : PageModel
    {
        private readonly ContentManagementSystem.Data.WebsiteContentContext _context;

        public DeleteModel(ContentManagementSystem.Data.WebsiteContentContext context)
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            TextContent = await _context.TextsContent.FindAsync(id);

            if (TextContent != null)
            {
                _context.TextsContent.Remove(TextContent);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}