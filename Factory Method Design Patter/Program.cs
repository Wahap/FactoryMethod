using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method_Design_Patter
{
    class Program
    {
        static void Main(string[] args)
        {
            IPaymentGateway gateway = null;
            PaymentGatewayFactory pgateway = new PaymentGatewayFactory();
            gateway = pgateway.GetGateway(BankType.BankA);

            gateway.MakePayment();

            gateway = pgateway.GetGateway(BankType.BankA);
            gateway.MakePayment();

        }
    }
}
