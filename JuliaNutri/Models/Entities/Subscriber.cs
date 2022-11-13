using JuliaNutri.Models.DTOs;
using JuliaNutri.Models.Interfaces;

namespace JuliaNutri.Models.Entities
{
    public class Subscriber : IEmailReceiver
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        public Subscriber() { }

        public Subscriber(CreateSubscriberDTO dto)
        {
            this.Name = dto.Name;
            this.Email = dto.Email;
            this.PhoneNumber = dto.PhoneNumber;
        }
    }
}
