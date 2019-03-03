namespace GPIB.Models
{
    public interface IUser
    {
        string Email { get; }
        
        string PasswordHash { get; }
    }
}