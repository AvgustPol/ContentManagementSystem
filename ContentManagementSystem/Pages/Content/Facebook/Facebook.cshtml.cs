using ContentManagementSystem.Pages.Content.Facebook.Logic;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Diagnostics;
using System.Threading.Tasks;

namespace ContentManagementSystem.Pages.Content.Facebook
{
    public class FacebookModel : PageModel
    {
        private IFacebookService _facebookService;

        public FacebookModel(IFacebookService facebookService)
        {
            _facebookService = facebookService;
        }

        public async Task OnGet()
        {
            var posts = await _facebookService.GetPostsAsync(100);

            Debug.Write("test");
        }

        //public async Task<IActionResult> GetPosts(int count = 100)
        //{
        //    var posts = await _facebookService.GetPostsAsync(count);
        //    if (posts == null)
        //    {
        //        return StatusCode(502);
        //    }

        //    return Ok(posts);
        //}
    }
}