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
    public class DetailsModel : PageModel
    {
        private readonly ContentManagementSystem.Data.WebsiteContentContext _context;

        public DetailsModel(ContentManagementSystem.Data.WebsiteContentContext context)
        {
            _context = context;
        }

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
    }
}
