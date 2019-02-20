using ContentManagementSystem.Data;
using ContentManagementSystem.Pages.Template;

namespace ContentManagementSystem.Pages
{
    public class ContactModel : PageTemplate
    {
        public ContactModel(WebsiteContentContext context) : base(context)
        {
        }

        public void OnGet()
        {
            Message = "Your contact page.";
        }
    }
}