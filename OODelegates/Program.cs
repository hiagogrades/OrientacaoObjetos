using System;

namespace OODelegates
{
    internal class Program
    {
        static void RealizarPagamento(double valor)
        {
            Console.WriteLine($"Pago o valor de {valor}");
        }

        static void Main(string[] args)
        {
            var pagar = new Pagamento.Pagar(RealizarPagamento);

            //Envoca a função delegada
            pagar(25);
        }
    }

    //Implementando o delegate
    public class Pagamento
    {
        //Definindo o construtor de maneira "padrão", sem o delegate
        //public void Pagar(double valor)
        //{

        //}

        //Utilizando o delagete para fazer o construtor em "outro lugar"
        public delegate void Pagar(double valor);
    }
}
