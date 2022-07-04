namespace ojt_management_api.Entities;

public class Semesters
{
    public int Id { get; set; } 
    public int SemesterNumber { get; set; }
    public int CompanyId { get; set; }
    public int UserId { get; set; }
    
    // Mapping with user and Company entities here
}