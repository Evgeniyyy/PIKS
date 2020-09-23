using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainofResponsibility
{
    class PayPalPaymentHandler : PaymentHandler
    {
        public override void Handle(Receiver receiver)
        {
            if (receiver.PayPalTransfer == true)
                Console.WriteLine("PayPal transfer in process...");
            else if (Successor != null)
                Successor.Handle(receiver);
        }
    }
}
