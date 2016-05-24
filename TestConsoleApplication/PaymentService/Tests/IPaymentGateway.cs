namespace PaymentServiceProject.Tests
{
    public interface IPaymentGateway
    {
        void PayWith(PaymentDetails paymentDetails);
    }
}