using JuliaNutri.Models.Interfaces;

namespace JuliaNutri.Services.Interfaces
{
    public interface IEmailService
    {
        public void SendEbook(IEmailReceiver receiver);

        public void SendEmail(IEmailReceiver receiver);
    }
}
