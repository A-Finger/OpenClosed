using OpenClosed.BL.Services.Interfaces;

namespace OpenClosed.BL.Services
{
	public class PayPalPaymentSevice : IPaymentService
	{
		public void ProcessPayment(decimal amount)
		{
			// Some logic

			Console.WriteLine($"Payment by PayPal: ${amount}");
		}
	}
}
