using System.ComponentModel.DataAnnotations;

namespace OnlineFoodOrderingSystem.Models
{
    public class RegisterVM
    {

        // FName, LNaME, eMAILId, MobileNumnber ,Passwrod //// Encryption,addr
        [Key]
        [Required(ErrorMessage = "ID is required")]
        public int ID { get; set; }
        public string emailID { get; set; }
        public string Fname { get; set; }
        public string LName { get; set; }       
        public int mobileNumber { get; set; }
        public string password { get; set; }
        public bool isActive { get; set; }

        // 1:N relationship → One RegisterVM can have many UserRoles
        public ICollection<UserRole> UserRoles { get; set; }

    }
}
