using System.ComponentModel.DataAnnotations;

namespace AssigmentPRN211.Models
{
    public class PersonSignUp
    {
        [Required(ErrorMessage = "Ten khong de trong")]
        
        public string FullName { get; set; }

        [Required(ErrorMessage = "Email khong de trong")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Mat khau khong de trong")]
        //[RegularExpression(@"^(?=.*[A-Za-z])(?=.*\d)(?=.*[@$!%*#?&])[A-Za-z\d@$!%*#?&]{6,}$", ErrorMessage = "Password minimum six characters, at least one letter, one number and one special character")]
        public string Password { get; set; }

        public string Gender { get; set; }
        public int? Type { get; set; }
        public bool? IsActive { get; set; }


    }
}
