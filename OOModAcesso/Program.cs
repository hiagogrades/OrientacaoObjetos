using System;
using System.Net;
using System.Security.Cryptography.X509Certificates;

namespace OOModAcesso
{
    class Program
    {
        static void Main(string[] args)
        {
            var payment = new Payment();

            
            
        }
    }

    public class Payment
    {
        protected DateTime Vencimento;
        
        void Pagar()
        {

        }
    }

    class PaymentTicket : Payment
    {
        public DateTime Vencimento;

        void Pagar()
        {

        }

        void Test()
        {
            //Utilizando o base para acessar as propriedades da classe 
            base.Vencimento = DateTime.Now;
        }
    }
}
