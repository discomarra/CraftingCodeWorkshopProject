namespace PaymentServiceProject.Tests
{
    public interface IUserService
    {
        bool HasValidAccount(User invalidUser);
    }
}