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

        struct Customer
        {
            public string Name;
        }
    }
}
