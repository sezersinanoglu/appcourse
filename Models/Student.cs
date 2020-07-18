using System.ComponentModel.DataAnnotations;

namespace appCourse.Models
{
    public class Student
    {
        [Required(ErrorMessage="ismnizi giriniz")]
        public string Name { get; set; }
        [Required(ErrorMessage="Mail adresinizi giriniz")]
        [EmailAddress(ErrorMessage="Email adresinizi doğru giriniz")]
        public string Email { get; set; }
        [Required(ErrorMessage="Telefon numarası giriniz")]
        public string Phone { get; set; }
        [Required]
        public bool? Confirm { get; set; }
    }
}