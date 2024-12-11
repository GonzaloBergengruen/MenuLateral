namespace MenuLateral.Models
{
    public class MenuItem
    {
        public string Title { get; set; }
        public Type TargetPage { get; set; }

        public MenuItem(string title, Type targetPage)
        {
            this.Title = title;
            this.TargetPage = targetPage;
        }
    }
}
