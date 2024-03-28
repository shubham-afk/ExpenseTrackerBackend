using System.ComponentModel.DataAnnotations;

namespace ExpenseApi
{
    public class ExpenseData
    {
        [Key]
        public string MonthName { get; set; }
        public int Personal { get; set; }
        public int Investment { get; set; }
        public int Luxury { get; set; }
        public int Food { get; set; }
        public int Miscellaneous { get; set; }
        public DateTime FirstExpenseDate { get; set; }
        public DateTime LatestExpenseDate { get; set; }
        public int NumberOfExpenses { get; set; }
        public int TotalAmount { get; set; }
    }
}
