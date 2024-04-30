namespace backend.Domain
{
    public class Note
    {
        public Guid Id { get; init; }
        public string Title { get; init; } = null!;
        public string Description { get; init; } = null!;
        public DateTime CreatedAt { get; init; }
        public DateTime UpdatedAt { get; init; }
        public AppUser Owner { get; init; } = null!;

        private Note ()
        {
        }

        public Note (
                string title,
                string description,
                AppUser owner)
        {
            Id = Guid.NewGuid();
            Title = title;
            Description = description;
            Owner = owner;
            CreatedAt = DateTime.UtcNow;
            UpdatedAt = DateTime.UtcNow;
        }
    }
}
