using ContentManagementSystem.Data.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace ContentManagementSystem.Pages.CMS.AllText
{
    public class DetailsModel : PageModel
    {
        private readonly ContentManagementSystem.Data.WebsiteContentContext _context;

        public DetailsModel(ContentManagementSystem.Data.WebsiteContentContext context)
        {
            _context = context;
        }

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
    }
}