using OpenClosed.BL.Services.Interfaces;

namespace OpenClosed.BL.Processes
{
	public class PaymentHandlerProcess
	{
		private readonly IPaymentService paymentService;

		public PaymentHandlerProcess(IPaymentService paymentService)
		{
			this.paymentService = paymentService;
		}

		public void ProcessPayment(decimal amount) => paymentService.ProcessPayment(amount);
	}
}
