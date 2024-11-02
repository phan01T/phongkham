namespace phongkhamthuy.Layout
{
    public class NewsItem
    {
        public string GetTitle()
        {
            return Title;
        }

        public void SetTitle(string value)
        {
            Title = value;
        }

        private string? url;

        public required string Title { get; set; }

        public string GetUrl()
        {
            return url;
        }

        public void SetUrl(string value)
        {
            url = value;
        }
    }
}
