namespace Assignment1.Data.Login
{
    public interface IUserService
    {
        User ValidateUser(string Username, string Password);
    }
}