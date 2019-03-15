using ExpenseTracker.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExpenseTracker.Api.Data
{
  public static class DbInitializer
  {
    public static void Initialize(ExpenseDb context)
    {
      //Here you'll use the EnsureCreated method to automatically create the database
      context.Database.EnsureCreated();

      if (context.ExpenseCategories.Any())
      {
        return;
      }

      var categories = new ExpenseCategory[]
      {
        new ExpenseCategory(){Name = "Food"},
        new ExpenseCategory(){Name = "Drinks"},
        new ExpenseCategory(){Name = "Fuel"},
        new ExpenseCategory(){Name = "Clothing"},
        new ExpenseCategory(){Name = "Transport"},
        new ExpenseCategory(){Name = "Personal"},
        new ExpenseCategory(){Name = "Fun"},
        new ExpenseCategory(){Name = "Health"},
        new ExpenseCategory(){Name = "Merchandise"},
        new ExpenseCategory(){Name = "Rent"},
        new ExpenseCategory(){Name = "Other"},
      };

      foreach (var c in categories)
      {
        context.ExpenseCategories.Add(c);
      }

      context.SaveChanges();
    }
  }
}