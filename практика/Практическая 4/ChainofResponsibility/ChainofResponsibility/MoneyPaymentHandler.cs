using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainofResponsibility
{
    class MoneyPaymentHandler : PaymentHandler
    {
        public override void Handle(Receiver receiver)
        {
            if (receiver.MoneyTransfer == true)
                Console.WriteLine("Money transfer in process...");
            else if (Successor != null)
                Successor.Handle(receiver);
        }
    }
}
