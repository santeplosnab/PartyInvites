using System.ComponentModel.DataAnnotations;

namespace PartyInvites.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage = "Please, enter your name.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please, enter your e-mail")]
        [RegularExpression(".+\\@.+\\..+",
            ErrorMessage = "Please enter a valid email addreess")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please, enter your Phone")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Please specify whether you'll attend")]
        public bool? WillAttend { get; set; } 
     }
}
