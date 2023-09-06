namespace TechStore.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LarstName { get; set; }
        public ICollection<Product>? Products { get; set; }
        public ICollection<Review>? Reviews { get; set; }
    }
}
