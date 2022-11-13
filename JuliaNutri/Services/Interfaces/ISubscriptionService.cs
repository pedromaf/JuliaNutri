using JuliaNutri.Models.DTOs;

namespace JuliaNutri.Services.Interfaces
{
    public interface ISubscriptionService
    {
        public void NewSubscription(CreateSubscriberDTO subscriber);
    }
}
