using ExpenseTracker.Api.Models;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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