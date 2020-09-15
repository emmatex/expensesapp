using System;
using System.ComponentModel.DataAnnotations;

namespace Expenses.Api.Models.Expenses
{
    public class CreateExpenseModel : ExpenseManipulationModel
    {
        [Required]
        public override DateTime Date { get; set; }
        [Required]
        public override string Description { get; set; }
        [Required]
        [Range(0.01, int.MaxValue)]
        public override decimal Amount { get; set; }
        [Required]
        public override string Comment { get; set; }
    }
}
