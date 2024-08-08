using System.Runtime.InteropServices.JavaScript;
using Task_Manager.Interfaces;

namespace Task_Manager.Models;

public class TaskModel : IIdentifiable
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
}