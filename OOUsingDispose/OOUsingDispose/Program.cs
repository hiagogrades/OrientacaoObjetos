using System;
using System.Net.WebSockets;

namespace OOUsingDispose
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dispose manual
            //var payment = new Payment();
            //payment.Dispose(); //Chamando o método Dispose para destruir a classe Payment

            //Forma automática de utilizar o garbage colletor
            using (var payment = new Payment())
            {
                Console.WriteLine("Processando pagamento.");
            }
        }

        public class Payment : IDisposable
        {
            //Garbage Colletor -> gc.collect

            //Define o Método construtor
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
