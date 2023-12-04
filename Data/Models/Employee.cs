using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Models
{
    public partial class Employee
    {
        public Employee()
        {
            BorrowRecords = new HashSet<BorrowRecord>();
        }

        public int EmployeeId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Idcard { get; set; }
        public string Address { get; set; }
        public string FullName { get; set; }
        public string EmployeeType { get; set; }
        public DateTime HireDate { get; set; }
        public decimal Salary { get; set; }

        public virtual ICollection<BorrowRecord> BorrowRecords { get; set; }
    }
}
