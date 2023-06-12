using OpenClosed.BL.Services.Interfaces;

namespace OpenClosed.BL.Services
{
	public class CashPaymentSevice : IPaymentService
	{
		public void ProcessPayment(decimal amount)
		{
			// Some logic

			Console.WriteLine($"Payment by cash: ${amount}");
		}
	}
}
