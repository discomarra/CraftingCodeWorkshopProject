using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace PaymentServiceProject.Tests
{
    public class PaymentServiceShould
    {
        private User invalidUser;
        private PaymentDetails paymentDetails;
        private Mock<IPaymentGateway> paymentGatewayMock = new Mock<IPaymentGateway>();
        private PaymentService paymentService;
        private Mock<IUserService> userServiceMock = new Mock<IUserService>();
        private User validUser;

        public PaymentServiceShould()
        {
            paymentService = new PaymentService(userServiceMock.Object, paymentGatewayMock.Object);
        }

        [Fact]
        public void ThrowExceptionWhenUserIsInvalid()
        {
            userServiceMock.Setup(x => x.HasValidAccount(invalidUser)).Returns(false);

            Assert.Throws<InvalidUserException>(() => paymentService.ProccessPayment(invalidUser, paymentDetails));
        }

        [Fact]
        public void NotInvokePaymentGatewayWhenUserAccountIsInvalid()
        {
            userServiceMock.Setup(x => x.HasValidAccount(invalidUser)).Returns(false);

            try
            {
                paymentService.ProccessPayment(invalidUser, paymentDetails);
            }
            catch (Exception)
            {
            }

            paymentGatewayMock.Verify(x => x.PayWith(paymentDetails), Times.Never);
        }

        [Fact]
        public void ProcessUserPaymentWhenUserIsValid()
        {
            userServiceMock.Setup(x => x.HasValidAccount(validUser)).Returns(true);

            paymentService.ProccessPayment(validUser, paymentDetails);

            paymentGatewayMock.Verify(x => x.PayWith(paymentDetails), Times.Once);
        }
    }
}
