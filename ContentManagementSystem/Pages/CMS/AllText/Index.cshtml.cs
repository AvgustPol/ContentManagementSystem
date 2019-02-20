using ContentManagementSystem.Data.Entities;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ContentManagementSystem.Pages.CMS.AllText
{
    public class IndexModel : PageModel
    {
        private readonly ContentManagementSystem.Data.WebsiteContentContext _context;

        public IndexModel(ContentManagementSystem.Data.WebsiteContentContext context)
        {
            _context = context;
        }

        public IList<TextContent> TextContent { get; set; }

        public async Task OnGetAsync()
        {
            TextContent = await _context.TextsContent.ToListAsync();
        }
    }
}