using System;
using System.Collections.Generic;
using System.Linq;

namespace OOListas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var payments = new List<Payment>();
            IList<Payment> payments = new List<Payment>();
            payments.Add(new Payment(1));
            payments.Add(new Payment(2));
            payments.Add(new Payment(3));
            payments.Add(new Payment(4));
            payments.Add(new Payment(5));

            foreach (var payment in payments)
            {
                Console.WriteLine(payment.Id);
            }

            ////Adiciona um bloco inteiro;
            //var paidPayments = new List<Payment>();
            //paidPayments.AddRange(payments); 
            //Console.WriteLine(paidPayments);

            //LINQ - Language Integrated Query
            //Retorna uma lista com todos os Id == 3
            //O WHERE sempre retornará uma lista, independente do número objetos encontrado na consulta
            var itensPayment = payments.Where(x => x.Id == 3);

            //Retorna o primeiro elemento de uma sequência atendendo a uma condição
            var itemPayment = payments.First(x => x.Id == 3);
            Console.WriteLine($"First result: {itemPayment.Id}");

            payments.Remove(itemPayment);

            foreach (var payment in payments)
            {
                Console.WriteLine(payment.Id);
            }

            //Any
            //Verifica se existe o Id=3 na lista 
            var exists = payments.Any(x => x.Id == 3);
            Console.WriteLine(exists);
        }
    }

    public class Payment
    {
        public int Id { get; set; }

        public Payment (int id)
        {
            Id = id;
        }
    }
}
