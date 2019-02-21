using ContentManagementSystem.Data;
using ContentManagementSystem.Data.Entities;
using ContentManagementSystem.Pages.Template;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ContentManagementSystem.Pages.Content
{
    public class IndexModel : PageTemplate
    {
        private readonly WebsiteContentContext _context;

        public IndexModel(WebsiteContentContext context) : base(context, "IndexModel")
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