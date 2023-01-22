using System;

namespace OObjetos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            var customer = new Customer();
            customer.Name = "Teste";


        }

        class Payment
        {
            //Propriedades
            DateTime Venciemnto;

            //Cria um método pagar
            void Pagar()
            {
                ConsultarSaldoDoCartao("1235464154561354");
            }

            //Utiliza a abstração para somente consultar o saldo de pagamento através do método pagar
            private void ConsultarSaldoDoCartao(string numero)
            {

            }
        }
    }
}
