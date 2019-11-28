using ExpenseTracker.Web.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExpenseTracker.Web.Data
{
  public class ExpenseDbContext : DbContext
  {
    public ExpenseDbContext(DbContextOptions options)
      :base(options)
    {

    }

    public DbSet<Expense> Expenses { get; set;}
    public DbSet<ExpenseCategory> ExpenseCategories { get; set; }
    public DbSet<PaymentType> PaymentTypes { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.Entity<ExpenseCategory>().HasData(new ExpenseCategory{Id = 1, Name = "Food"});
      modelBuilder.Entity<ExpenseCategory>().HasData(new ExpenseCategory { Id = 2, Name = "Travel" });
      modelBuilder.Entity<ExpenseCategory>().HasData(new ExpenseCategory { Id = 3, Name = "Entertainment" });

      modelBuilder.Entity<PaymentType>().HasData(new PaymentType { Id = 1, Name = "Cash" });
      modelBuilder.Entity<PaymentType>().HasData(new PaymentType { Id = 2, Name = "Card" });
    }
  }
}
