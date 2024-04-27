namespace backend.Domain
{
    public class Note
    {
        public Guid Id { get; set; }
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public AppUser Owner { get; set; } = null!;
    }
}
