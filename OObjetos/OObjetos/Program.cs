using System;

namespace OObjetos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            //Conceito de Herança
            //Instanciando os objetos da classe PaymentBoleto
            var paymentTicket = new PaymentTicket();
            paymentTicket.Pagar();
            paymentTicket.Venciemnto = DateTime.Now;
            paymentTicket.NumberTicket = "1355641335435";
            
            //Instanciando os objetos da classe PaymentCartaoCredito
            var paymentCardCredit = new PaymentCardCredit();
            paymentCardCredit.NumberCardCredit = "654564654545645";
        }

        class Payment
        {
            //Propriedades
            public DateTime Venciemnto;

            //Cria um método pagar
            public void Pagar()
            {
                //Abstração
                //ConsultarSaldoDoCartao("1235464154561354");

                //Herança

            }

            ////Abstração
            ////Utiliza a abstração para somente consultar o saldo de pagamento através do método pagar
            //private void ConsultarSaldoDoCartao(string numero)
            //{

            //}
        }

        //A Classe PaymentBoleto está herdando de Payment
        class PaymentTicket : Payment
        {
            public string NumberTicket;
        }

        class PaymentCardCredit : Payment
        {
            public string NumberCardCredit;
        }
    }
}
