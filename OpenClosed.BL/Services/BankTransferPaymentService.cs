using OpenClosed.BL.Services.Interfaces;

namespace OpenClosed.BL.Services
{
	public class BankTransferPaymentService : IPaymentService
	{
		public void ProcessPayment(decimal amount)
		{
            // Some logic

            Console.WriteLine($"Payment by bank transfer: ${amount}");
        }
	}
}
