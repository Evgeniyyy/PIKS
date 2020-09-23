using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainofResponsibility
{
    class BankPaymentHandler : PaymentHandler
    {
        public override void Handle(Receiver receiver)
        {
            if (receiver.BankTransfer == true)
                Console.WriteLine("Bank transfer in process...");
            else if (Successor != null)
                Successor.Handle(receiver);

        }
    }
}
