namespace TodoApp.Model
{
    public class Todo
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public bool isDone { get; set; } = false;
        public DateTime Date { get; set; } = DateTime.Now;
        public DateTime? CompletionDate { get; set; } 
    }
}
