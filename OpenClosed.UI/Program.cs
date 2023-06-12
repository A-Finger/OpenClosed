using OpenClosed.BL.Processes;

namespace OpenClosed.UI
{
	internal class Program
	{
		static void Main(string[] args)
		{
			decimal upTo = 131.09m;

            Console.WriteLine($"Up to: ${upTo}");
            Console.WriteLine(new String('-', 50));
            Console.WriteLine("Choose a payment method:");
            Console.WriteLine("\t1 - Bank Transfer Payment");
			Console.WriteLine("\t2 - Cash Payment");
			Console.WriteLine("\t3 - CreditCard Payment");
			Console.WriteLine("\t4 - PayPal Payment");
			string payment = Console.ReadLine()!;
			try
			{
				var paymentHandlerProcess = new PaymentHandlerProcess(Helper.ChoosePaymentService(payment));
				paymentHandlerProcess.ProcessPayment(upTo);
				Console.ReadKey();
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
		}
	}
}