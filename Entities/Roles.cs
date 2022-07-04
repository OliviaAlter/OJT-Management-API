namespace ojt_management_api.Entities;

public class Roles
{
    public int RoleId { get; set; }
    public string RoleName { get; set; }
    
    // mapping to user entity
    public int UserId { get; set; }
}