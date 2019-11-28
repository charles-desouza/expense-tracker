namespace ExpenseTracker.Web.Models
{
  public class Expense
  {
    public int Id { get; set; }
    public string Title { get; set; }
    public int? ExpenseCategoryId { get; set; }
    public int? PaymentTypeId { get; set; }
    public float Amount { get; set; }

    public ExpenseCategory ExpenseCategory { get; set; }
    public PaymentType PaymentType { get; set; }
  }
}
