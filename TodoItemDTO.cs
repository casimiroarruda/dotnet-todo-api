public class TodoItemDTO
{
    public int Id { get; set; }
    public string? Title { get; set; }
    public bool IsComplete { get; set; }
    public DateTime? DueDate { get; set; }
    public string? Description { get; set; }
    public List<string>? Tags { get; set; }

    public TodoItemDTO() { }
    public TodoItemDTO(Todo todoItem) =>
    (Id, Title, IsComplete, DueDate, Description, Tags) = (todoItem.Id, todoItem.Title, todoItem.IsComplete, todoItem.DueDate, todoItem.Description, todoItem.Tags);
}