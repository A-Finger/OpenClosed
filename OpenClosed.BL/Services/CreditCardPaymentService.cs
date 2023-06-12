using OpenClosed.BL.Services.Interfaces;

namespace OpenClosed.BL.Services
{
	public class CreditCardPaymentService : IPaymentService
	{
		public void ProcessPayment(decimal amount)
		{
            // Some logic

            Console.WriteLine($"Payment by credit card: {amount}$");
        }
	}
}
