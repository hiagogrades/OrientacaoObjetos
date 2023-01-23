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
            paymentTicket.Vencimento = DateTime.Now;
            paymentTicket.NumberTicket = "1355641335435";
            
            //Instanciando os objetos da classe PaymentCartaoCredito
            var paymentCardCredit = new PaymentCardCredit();
            paymentCardCredit.NumberCardCredit = "654564654545645";

            //Sobrescrevendo o método Payment
            var payment = new Payment();
            payment.ToString();
        }

        class Payment
        {
            //Propriedades
            public DateTime Vencimento;

            //Cria um método pagar
            //Utiliza virtual para sobrescrever o método Pagar
            public virtual void Pagar()
            {
                //Abstração
                //ConsultarSaldoDoCartao("1235464154561354");

                //Herança

            }

            public override string ToString()
            {
                return Vencimento.ToString("dd/MM/yy"); 
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

            //Sobrescrevendo o método pagar
            public override void Pagar() { }
        }

        class PaymentCardCredit : Payment
        {
            public string NumberCardCredit;

            //Sobrescrevendo o método pagar
            public override void Pagar() { }
        }
    }
}
