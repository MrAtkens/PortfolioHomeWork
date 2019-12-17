using System.ComponentModel.DataAnnotations;

namespace PortfolioAspNetCore.ViewModel
{
    public class UserViewModel
    {
        [Required]
        public string Login { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
