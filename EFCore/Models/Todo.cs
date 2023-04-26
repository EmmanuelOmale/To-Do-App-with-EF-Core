namespace EFCore.Models
{
    public class Todo
    {
        public int Id { get; set; }
        public string TaaskTitle { get; set; } = null!;
        public string TaaskDescription { get; set; } = null!;
        public DateTime ScheduledDate { get; set; } = DateTime.Now;
        public DateTime CompletionDate { get; set; } = DateTime.Now;

        public DateTime DateCreated { get; set; } = DateTime.Now;
    }
}


