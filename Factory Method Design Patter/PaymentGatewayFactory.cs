using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method_Design_Patter
{
   public class PaymentGatewayFactory
    {
        public virtual IPaymentGateway GetGateway(BankType bankType)
        {
            IPaymentGateway gateway = null;

            switch (bankType)
            {
                case BankType.BankA:
                    gateway = new BankA();
                    break;
                case BankType.BankB:
                    gateway = new BankB();
                    break;
            }

            return gateway;
        }
    }
   public enum BankType
    {
        BankA,
        BankB

    }
}
