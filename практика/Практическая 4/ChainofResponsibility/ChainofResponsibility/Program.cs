using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainofResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            Receiver receiver = new Receiver(false, false, true);
            PaymentHandler bankPaymentHandler = new BankPaymentHandler();
            PaymentHandler moneyPaymentHandler = new MoneyPaymentHandler();
            PaymentHandler paypalPaymentHandler = new PayPalPaymentHandler();

            paypalPaymentHandler.Successor = bankPaymentHandler;
            bankPaymentHandler.Successor = paypalPaymentHandler;

            bankPaymentHandler.Handle(receiver);
        }
    }
}
