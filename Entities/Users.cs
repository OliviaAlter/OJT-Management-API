namespace ojt_management_api.Entities;

public class Users
{
    public int UserId { get; set; }
    public string Username { get; set; }
    public byte[] PasswordHash { get; set; }
    public byte[] PasswordSalt { get; set; }
    
    // mapping to Roles entities, Semester entities & Major entities

    public int SemesterNumber { get; set; }
    public int RoleId { get; set; }
    public int MajorId { get; set; }
    
    // Mapping with Class Name here
}