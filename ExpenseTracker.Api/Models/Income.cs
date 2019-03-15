using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExpenseTracker.Api.Models
{
  public class Income
  {
    public int Id { get; set; }
    public IncomeSource Source { get; set; }
    public decimal Amount { get; set; }
    public DateTime DateTime { get; set; }
  }
}