using ContentManagementSystem.Data;
using ContentManagementSystem.Data.Entities;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace ContentManagementSystem.Pages.Template
{
    public abstract class PageTemplate : PageModel
    {
        // create razor page
        // swap the page model to PageTemplate

        // at PageTemplate

        // Add rendering page elements like partial views
        // TODO: add partial views to each content type (e.g. image -> partial view with img in a nice <div>)

        public string Message { get; set; }

        public PageTemplate(WebsiteContentContext context, string pageName)
        {
            var allPages = context.PagesContent.Include(x => x.PageName).ToList();

            //var pageName = ViewContext.RouteData.Values["controller"].ToString();

            PageContent = allPages.Find(x => x.PageName == PageName);
            PageName = pageName;
        }

        public PageContent PageContent { get; set; }
        public string PageName { get; set; }

        public string PageTitle => PageContent.PageTitle;
    }
}