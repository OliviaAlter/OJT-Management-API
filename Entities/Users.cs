namespace ojt_management_api.Entities;

public class Users
{
    public int Id { get; set; }
    public string Username { get; set; }
    public byte[] PasswordHash { get; set; }
    public byte[] PasswordSalt { get; set; }
    
    // mapping to Roles entities, Semester entities & Major entities
}