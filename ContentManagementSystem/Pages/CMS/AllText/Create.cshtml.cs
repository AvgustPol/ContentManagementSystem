using ContentManagementSystem.Data.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;

namespace ContentManagementSystem.Pages.CMS.AllText
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
        public TextContent TextContent { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.TextsContent.Add(TextContent);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}