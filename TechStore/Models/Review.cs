namespace TechStore.Models
{
    public class Review
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int ProiductId { get; set; } 
        public int Rate { get; set; }
        public string? Discription { get; set; }
        public DateTime Date { get; set; }
    }
}
