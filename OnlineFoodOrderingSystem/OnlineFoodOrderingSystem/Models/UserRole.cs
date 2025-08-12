using System.ComponentModel.DataAnnotations;

namespace OnlineFoodOrderingSystem.Models
{
    public class UserRole
    {
      
        [Key]
        public int UserRoleId { get; set; } // PK

        // Foreign key to RegisterVM
        public int RegisterVMId { get; set; }

        // Role details
        public string Role { get; set; }

        // Navigation back to RegisterVM
        public RegisterVM RegisterVM { get; set; }
    }
}
