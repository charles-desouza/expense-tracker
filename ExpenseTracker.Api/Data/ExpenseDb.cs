using ExpenseTracker.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace ExpenseTracker.Api.Data
{
  public class ExpenseDb : DbContext
  {
    public ExpenseDb(DbContextOptions<ExpenseDb> options) : base(options)
    {
    }

    public DbSet<Expense> Expenses { get; set; }
    public DbSet<ExpenseCategory> ExpenseCategories { get; set; }
  }
}