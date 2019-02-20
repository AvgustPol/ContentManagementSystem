using ContentManagementSystem.Data;
using ContentManagementSystem.Data.Entities;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace ContentManagementSystem.Pages.Template
{
    public abstract class PageTemplate : PageModel
    {
        public string Message { get; set; }

        public PageTemplate(WebsiteContentContext context)
        {
            var allPages = context.PagesContent.Include(x => x.PageName).ToList();

            //var pageName = ViewContext.RouteData.Values["controller"].ToString();

            PageContent = allPages.Find(x => x.PageName == PageName);
        }

        public PageContent PageContent { get; set; }
        public string PageName { get; set; }

        public string PageTitle => PageContent.PageTitle;
    }
}