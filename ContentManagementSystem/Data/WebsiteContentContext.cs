using ContentManagementSystem.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace ContentManagementSystem.Data
{
    public class WebsiteContentContext : DbContext
    {
        public WebsiteContentContext(DbContextOptions<WebsiteContentContext> dbContextOptions) : base(dbContextOptions)
        {
        }

        public DbSet<PageContent> PagesContent { get; set; }
        public DbSet<TextContent> TextsContent { get; set; }
        public DbSet<Image> ImageContent { get; set; }
    }
}