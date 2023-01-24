using System;
using System.Net.WebSockets;

namespace OOUsingDispose
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dispose manual **
            //var payment = new Payment();
            //payment.Dispose(); //Chamando o método Dispose para destruir a classe Payment

            //Forma automática de utilizar o garbage colletor
            using (var payment = new Payment())
            {
                Console.WriteLine("Processando pagamento.");

                //Partial Class **
                var paymentPartialClass = new PaymentPartialClass();
                paymentPartialClass.CIC = "16167217742";
                paymentPartialClass.NameClient = "Hiago Grades Werneck";
                paymentPartialClass.NumberCard = "1111 2222 3333 4444";
                paymentPartialClass.EmissaoCard = DateTime.Now;
                paymentPartialClass.VencimentoCard = DateTime.Now.AddMonths(60);


                Console.WriteLine(paymentPartialClass.NameClient);
                Console.WriteLine(paymentPartialClass.CIC);
                Console.WriteLine(paymentPartialClass.NumberCard);
                Console.WriteLine(paymentPartialClass.EmissaoCard);
                Console.WriteLine(paymentPartialClass.VencimentoCard);
            }
        }

        public class Payment : IDisposable
        {
            //Garbage Colletor -> gc.collect **

            //Define o Método construtor **
            public Payment()
            {
                Console.WriteLine("Iniciando o pagamento.");
            }

            public void Dispose()
            {
                Console.WriteLine("Finalizando o pagamento.");
            }
        }
    }
}
