namespace Task_Manager.Models;

public class User
{
    public int Id { get; set; }
    public string Name { get; set; }
    public TaskModel[]? ActiveTasks { get; set; }
    public TaskModel[]? CompletedTasks { get; set; }
}