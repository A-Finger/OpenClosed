using OpenClosed.BL.Services;
using OpenClosed.BL.Services.Interfaces;

namespace OpenClosed.UI
{
	public static class Helper
	{
		public static IPaymentService ChoosePaymentService(string value)
		{
			return value switch
			{
				"1" => new BankTransferPaymentService(),
				"2" => new CashPaymentSevice(),
				"3" => new CreditCardPaymentService(),
				"4" => new PayPalPaymentSevice(),
				_ => throw new NotImplementedException("Wrong payment method selected!")
			};
		}
	}
}
