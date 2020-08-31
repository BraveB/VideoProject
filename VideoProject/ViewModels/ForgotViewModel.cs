using System.ComponentModel.DataAnnotations;

namespace VideoProject.ViewModels
{
    public class ForgotViewModel
    {
        [Required]
        [Display(Name = "Correo electrónico")]
        public string Email { get; set; }
    }
}