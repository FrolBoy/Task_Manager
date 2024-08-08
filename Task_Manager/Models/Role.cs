using Task_Manager.Interfaces;

namespace Task_Manager.Models;

public class Role : IIdentifiable
{
    public int Id { get; set; }
    public string RoleName { get; set; }
    public int PermissionLevel { get; set; }
    
}