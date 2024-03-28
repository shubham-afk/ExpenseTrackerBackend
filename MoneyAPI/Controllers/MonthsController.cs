using ExpenseApi;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

[Route("api/[controller]")]
    [ApiController]
    public class MonthsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public MonthsController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ExpenseData>>> GetMonths()
        {
            return await _context.ExpenseDatas.ToListAsync();
        }

        [HttpGet("getByMonthName/{monthName}")]
        public IActionResult GetExpensesByMonthName(string monthName)
        {
            try
            {
                var expense = _context.ExpenseDatas.FirstOrDefault(e => e.MonthName == monthName);

                if (expense == null) {
                return NotFound($"Not found for the month{monthName}");
                
                }

            var result = new
            {
                MonthName = expense.MonthName,
                Personal = expense.Personal,
                Investment = expense.Investment,
                Luxury = expense.Luxury,
                Food = expense.Food,
                Miscellaneous = expense.Miscellaneous,
                FirstExpenseDate = expense.FirstExpenseDate,
                LatestExpenseDate = expense.LatestExpenseDate,
                NumberOfExpenses = expense.NumberOfExpenses,
                TotalAmount = expense.TotalAmount
            };

            return Ok(result);  
            }

        catch (Exception ex)
        {
            return StatusCode(500,$"Internal server error: {ex.Message}");
        }
        }

        [HttpPut("updateByMonthName/{monthName}")]
        public IActionResult UpdateExpensesByMonthName(string monthName , [FromBody]ExpenseData expenseData)
        {
            try
            {
            var expense = _context.ExpenseDatas.FirstOrDefault(e => e.MonthName == monthName);

            if(expense == null) 
            {
                return NotFound($"Not found for the month ${monthName}");
            }

            expense.Personal = expenseData.Personal;
            expense.Investment = expenseData.Investment;
            expense.Luxury = expenseData.Luxury;
            expense.Food = expenseData.Food;
            expense.Miscellaneous = expenseData.Miscellaneous;

            _context.SaveChanges();

            return Ok("Expense updated Successfully");
            }

        catch (Exception ex)
        {
            return StatusCode(500, $"Internal Server Message: {ex.Message}");
        }
        }
    }
