using Microsoft.EntityFrameworkCore;

namespace RecLP3.Models;

public class RecLP3Context : DbContext
{
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Employee> Employees { get; set; }
    public RecLP3Context(DbContextOptions<RecLP3Context> options) : base(options)
    {
        
    }
}