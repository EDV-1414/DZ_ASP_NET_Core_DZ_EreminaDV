namespace TODOlist
{
    public class TODO
    {
        public string Description { get; set; }
        public bool DONE { get; set; }
        // Добавлено поле CreatedAt — дата и время создания задачи.
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public override bool Equals(object? other)
        {
            return this.Description.Equals((other as TODO).Description);
        }
    }
}