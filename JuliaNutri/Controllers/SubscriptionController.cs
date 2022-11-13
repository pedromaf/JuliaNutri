using JuliaNutri.Models.DTOs;
using JuliaNutri.Services;
using JuliaNutri.Services.Interfaces;
using JuliaNutri.Util;
using Microsoft.AspNetCore.Mvc;

namespace JuliaNutri.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SubscriptionController : ControllerBase
    {
        private readonly ISubscriptionService _subscriptionService;
        public SubscriptionController(ISubscriptionService subscriptionService)
        {
            _subscriptionService = subscriptionService;
        }

        [HttpPost]
        public IActionResult CreateSubscription(CreateSubscriberDTO subscriber)
        {
            try
            {
                _subscriptionService.NewSubscription(subscriber);
                
                return Ok();
            }
            catch(ArgumentException exc) { return this.HandleException(exc); }
        }
    }
}
