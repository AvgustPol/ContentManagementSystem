using ContentManagementSystem.Data;
using ContentManagementSystem.Data.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ContentManagementSystem.Pages.CMS.Images
{
    public class TestUploadModel : PageModel
    {
        private readonly WebsiteContentContext _context;

        public TestUploadModel(WebsiteContentContext context)
        {
            _context = context;
            AllImagesSrc = new List<string>();
        }

        [BindProperty]
        public string ImageData { get; set; }

        [BindProperty]
        public List<string> AllImagesSrc { get; set; }

        public void OnGet()
        {
            var AllImages = _context.ImageContent.ToList();
            if (AllImages.Count != 0)
            {
                foreach (Image image in AllImages)
                {
                    if (image.Data != null)
                    {
                        ImageData = @"data:image / jpeg; base64," + Convert.ToBase64String(image.Data);
                    }
                    else
                    {
                        ImageData = @"https://sitechecker.pro/wp-content/uploads/2017/12/404.png";
                    }
                    AllImagesSrc.Add(ImageData);
                }
            }
        }

        public async Task<IActionResult> OnPost(List<IFormFile> files)
        {
            foreach (var uploadedImage in files)
            {
                if (uploadedImage == null || uploadedImage.ContentType.ToLower().StartsWith("image/"))
                {
                    using (var memoryStream = new MemoryStream())
                    {
                        uploadedImage.OpenReadStream().CopyTo(memoryStream);

                        Image imageEntity = new Image()
                        {
                            Length = uploadedImage.Length,
                            Name = uploadedImage.Name,
                            Data = memoryStream.ToArray(),
                            ContentType = uploadedImage.ContentType
                        };

                        _context.ImageContent.Add(imageEntity);
                    }
                }
            }

            await _context.SaveChangesAsync();

            return RedirectToPage("./TestUpload");
        }
    }
}