using System;
using System.Collections.Generic;
using System.Text;

namespace OOPTASKS.src
{
    public class HandPay
    {
        public virtual void Pay(double amount)
        {
            Console.WriteLine($"{amount}$ Paying successfull with hand");
        }
    }
    internal class CartPay : HandPay
    {
        public override void Pay(double amount)
        {
            double commision1 = 1;
            commision1 = amount * commision1 / 100;
            Console.WriteLine($"{amount}$ Paying successfull with cart and 1% commision: {commision1}$");
        }
    }
}
