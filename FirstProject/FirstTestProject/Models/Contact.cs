using System.ComponentModel.DataAnnotations;

namespace FirstTestProject.Models
{
    public class Contact
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Number { get; set; }
    }
}
