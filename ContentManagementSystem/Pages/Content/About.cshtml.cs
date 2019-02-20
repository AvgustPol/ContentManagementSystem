using ContentManagementSystem.Data;
using ContentManagementSystem.Data.Entities;
using ContentManagementSystem.Pages.Template;
using System;

namespace ContentManagementSystem.Pages
{
    public class AboutModel : PageTemplate
    {
        private readonly WebsiteContentContext _context;

        public string TestImagine { get; set; }
        public string TestText { get; set; }
        public TextContent TextContent { get; set; }

        public AboutModel(WebsiteContentContext context) : base(context)
        {
            _context = context;

            TestText = ((TextContent)PageContent.Content[0]).Text;

            var image = (Image)PageContent.Content[5];

            if (image.Data != null)
            {
                TestImagine = @"data:image / jpeg; base64," + Convert.ToBase64String(image.Data);
            }
            else
            {
                TestImagine = @"https://sitechecker.pro/wp-content/uploads/2017/12/404.png";
            }
        }

        public void OnGet()
        {
        }
    }
}