using JuliaNutri.Models.DTOs;
using JuliaNutri.Services;
using JuliaNutri.Services.Interfaces;
using JuliaNutri.Util;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
            catch (ArgumentException exc) { return this.HandleException(exc); }
            catch (DbUpdateConcurrencyException exc) { return this.HandleException(exc); }
            catch (DbUpdateException exc) { return this.HandleException(exc); }
            catch (NotImplementedException exc) { return this.HandleException(exc); } // TODO: Remove after function implementation.
        }
    }
}
