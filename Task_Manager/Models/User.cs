using Task_Manager.Interfaces;

namespace Task_Manager.Models;

public class User : IIdentifiable
{
    public int Id { get; set; }
    public string Name { get; set; }
    public virtual List<TaskModel>? ActiveTasks { get; set; }
    public virtual List<TaskModel>? CompletedTasks { get; set; }
    public Role? UserRole { get; set; }
}