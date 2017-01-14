using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method_Design_Patter
{
    class BankB : IPaymentGateway
    {
        public void MakePayment()
        {
            Console.WriteLine("Payments from BankB");
        }
    }
}
