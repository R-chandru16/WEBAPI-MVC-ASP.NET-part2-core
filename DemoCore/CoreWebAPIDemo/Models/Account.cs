using System.ComponentModel.DataAnnotations;

namespace CoreWebAPIDemo.Models
{
    public class Account
    {
        [Key]
        public int AccountId { get; set; }
        [Required]
        [MaxLength(100)]
        public string AccountName { get; set; }
        [Required]
        [MaxLength(10)]
        public string AccountType { get; set; }
    }
}
