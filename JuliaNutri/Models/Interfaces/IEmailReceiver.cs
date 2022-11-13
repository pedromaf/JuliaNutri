namespace JuliaNutri.Models.Interfaces
{
    public interface IEmailReceiver
    {
        string Name { get; set; }
        string Email { get; set; }
        string PhoneNumber { get; set; }
    }
}
