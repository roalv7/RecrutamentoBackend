using System.ComponentModel.DataAnnotations;

namespace RecrutamentoWebAPI.Models
{
    public class Interest
    {
        [Required]
        public string Description { get; set; }
    }
}
