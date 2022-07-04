using API.Entities;
using Microsoft.EntityFrameworkCore;
using ojt_management_api.Entities;

namespace ojt_management_api.Data;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Users> Users { get; set; }
}