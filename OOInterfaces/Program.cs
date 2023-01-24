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

        public virtual void Pagar (double valor)
        {

        }
    }

    public class PaymentCreditCard : Payment
    {
        public override void Pagar(double valor)
        {
            base.Pagar(valor);
        }
    }

    //Classe abstract
    //Está dizendo que está classe não pode ser instanciada
    //Class abstract não pode ser instanciada e sim herdada.
    public abstract class PaymentTicket : Payment
    {
        public override void Pagar(double valor)
        {
            base.Pagar(valor);
        }
    }

    public class PaymentApplePay : Payment
    {
        public override void Pagar(double valor)
        {
            base.Pagar(valor);
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
