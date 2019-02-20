namespace ContentManagementSystem.Data.Entities
{
    public class Image : ContentComponent
    {
        public string Name { get; set; }

        public byte[] Data { get; set; }

        public long Length { get; set; }

        //public int Width { get; set; }

        //public int Height { get; set; }

        public string ContentType { get; set; }
    }
}