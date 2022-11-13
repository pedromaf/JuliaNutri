using JuliaNutri.Data;
using JuliaNutri.Models.DTOs;
using JuliaNutri.Models.Entities;
using JuliaNutri.Services.Interfaces;

namespace JuliaNutri.Services
{
    public class SubscriptionService : ISubscriptionService
    {
        private readonly JuliaNutriDbContext _context;
        private readonly IEmailService _emailService;

        public SubscriptionService(JuliaNutriDbContext context, IEmailService emailService)
        {
            _context = context;
            _emailService = emailService;
        }

        public void NewSubscription(CreateSubscriberDTO dto)
        {
            Subscriber newSubsciber = new Subscriber(dto);

            _context.Subscribers.Add(newSubsciber);
            _context.SaveChanges();

            _emailService.SendEbook(newSubsciber);
        }
    }
}
