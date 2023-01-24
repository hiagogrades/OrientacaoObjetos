using System;

namespace OOInterfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
        }
    }

    public class Payment : IPayment
    {
        public DateTime Vencimento { get; set; }

        public void Pagar (double valor)
        {

        }
    }

    public interface IPayment
    {
        DateTime Vencimento { get; set; }

        void Pagar (double valor)
        {

        }
    }
}
