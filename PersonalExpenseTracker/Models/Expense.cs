using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PersonalExpenseTracker.Models
{
    public class Expense
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required]
        public decimal Amount { get; set; }

        [Required]
        public string Category { get; set; } = "Other";

        public string? Description { get; set; }

        private DateTime _spentAt;

        [Required]
        public DateTime SpentAt
        {
            get => _spentAt;
            set => _spentAt = DateTime.SpecifyKind(value, DateTimeKind.Utc);
        }

        private DateTime _createdAt = DateTime.UtcNow;

        public DateTime CreatedAt
        {
            get => _createdAt;
            set => _createdAt = DateTime.SpecifyKind(value, DateTimeKind.Utc);
        }

        [Required]
        public string UserId { get; set; }

        [ForeignKey("UserId")]
        public virtual ApplicationUser User { get; set; }
    }
}