using System;

namespace OOUpcastDowcast
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Upcast
            var pessoa = new Person();
            var pessoaFisica = new Personal();
            var pessoaJuridica = new Corporate();

            var

            //Downcast
            pessoaFisica = (Personal)pessoa; //Realiza uma conversão de tipo para Personal


        }
    }

    public class Person
    {
        public string Name { get; set; }
    }

    public class Personal : Person 
    {
        public string CIC { get; set; }
    }

    public class Corporate : Person
    {
        public string CGC { get; set; }
    }
}
