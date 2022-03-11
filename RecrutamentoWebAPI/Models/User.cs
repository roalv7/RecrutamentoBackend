using System.ComponentModel.DataAnnotations;

namespace RecrutamentoWebAPI.Models
{
    public class User
    {
        [Required]
        public string Name { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Number { get; set; }
        [Required, MinLength(1)]
        public string[] Interests { get; set; }

        public string? Message { get; set; }

    }
}
