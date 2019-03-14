using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExpenseTracker.Api.Models
{
  public class ExpenseItem
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Amount { get; set; }
    public int CategoryId { get; set; }
    public DateTime DateTime { get; set; }

    public ExpenseCategory Category { get; set; }
  }
}