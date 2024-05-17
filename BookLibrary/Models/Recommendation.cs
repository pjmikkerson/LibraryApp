namespace Library.Models
{
    public class Recommendation
    {
        public int Id { get; set; }
        public int BookId { get; set; } 
        public bool IsRead { get; set; } = false;
        public string? AddedByUserId { get; set; } 
        
    }
}
