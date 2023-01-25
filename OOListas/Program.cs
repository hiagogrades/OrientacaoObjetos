using System;
using System.Collections.Generic;

namespace OOListas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var payments = new List<Payment>();
            IList<Payment> payments = new List<Payment>();
            payments.Add(new Payment());
            payments.Remove(new Payment());
        }
    }

    public class Payment
    {

    }
}
