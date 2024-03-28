using ExpenseApi;
using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)  { }

        public DbSet<ExpenseData> ExpenseDatas { get; set; }


    }