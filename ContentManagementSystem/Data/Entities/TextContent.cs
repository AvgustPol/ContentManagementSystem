namespace ContentManagementSystem.Data.Entities
{
    public class TextContent : ContentComponent
    {
        public Language Language { get; set; } = Language.POLISH;
        public string Title { get; set; }
        public string Text { get; set; }

        public PageContent Page { get; set; }
    }
}