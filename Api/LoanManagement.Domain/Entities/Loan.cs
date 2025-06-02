using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanManagement.Domain.Entities
{
    public class Loan
    {
        public Guid Id { get; set; }
        public string LoanType { get; set; } = string.Empty;
        public decimal Amount { get; set; }
        public double InterestRate { get; set; }
        public int TermInMonths { get; set; }
        public Guid UserId { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
