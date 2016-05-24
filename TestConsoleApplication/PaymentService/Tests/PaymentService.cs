using System;

namespace PaymentServiceProject.Tests
{
    public class PaymentService
    {
        private IUserService userService;
        private IPaymentGateway paymentGateway;

        public PaymentService(IUserService userService, IPaymentGateway paymentGateway)
        {
            this.userService = userService;
            this.paymentGateway = paymentGateway;
        }

        public void ProccessPayment(User invalidUser, PaymentDetails paymentDetails)
        {
            if (!userService.HasValidAccount(invalidUser))
            {
                throw new InvalidUserException();
            }

            paymentGateway.PayWith(paymentDetails);
        }
    }
}