using System.ComponentModel.DataAnnotations;

namespace belt_exam.Models
{
    public class LoginCheck
    {
        [Required]
        public string LoginEmail { get; set; }
        [Required]
        public string LoginPassword { get; set; }
        public LoginCheck() { }
    }
}