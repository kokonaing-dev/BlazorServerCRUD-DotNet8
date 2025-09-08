namespace BlazorServerCrudDotNet8.Models
{
    public class Menu
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
        public string Icon { get; set; }
        public int? ParentId { get; set; }
    }

}
