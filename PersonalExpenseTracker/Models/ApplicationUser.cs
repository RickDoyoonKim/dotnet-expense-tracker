using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace PersonalExpenseTracker.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public virtual ICollection<Expense> Expenses { get; set; }
    }
}