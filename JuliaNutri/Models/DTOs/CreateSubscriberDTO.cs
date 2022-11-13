using JuliaNutri.Resources;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace JuliaNutri.Models.DTOs
{
    public class CreateSubscriberDTO
    {
        [Required(ErrorMessage = Messages.SUBSCRIBER_NAME_REQUIRED)]
        [StringLength(50, ErrorMessage = Messages.SUBSCRIBER_NAME_TOO_LONG)]
        public string Name { get; set; }

        [Required(ErrorMessage = Messages.SUBSCRIBER_EMAIL_REQUIRED)]
        public string Email { get; set; }

        public string PhoneNumber  { get; set; }
    }
}
