using System;
using System.ComponentModel.DataAnnotations;

namespace OOGenerics
{
    internal class Program
    {
        //static void Main(string[] args)
        //{
        //    var context = new DataContext<Person>();
        //    var person = new Person();
        //    context.Save(person); //Salvando uma pessoa
        //}

        static void Main(string[] args)
        {
            var person = new Person();
            var payment = new Payment();
            var subscription = new Subscription();
            var context = new DataContext<Person, Payment, Subscription>();

            context.Save(person);
            context.Save(payment);
            context.Save(subscription);
        }
    }

    //Para dizer que uma classe é genérica em C#, utilize os sinais (<>);
    //Como por exemplo <TipoDaClasse>
    //DataContext<T>
    //public class DataContext<T>
    //{
    //    //Método para salvar as informações
    //    public void Save(T entity)
    //    {
    //    }
    //}

    //Mais de um tipo genérico
    //Where => utilizar para explicitar suas respectivas ordens e letras
    public class DataContext<P, PA, S>
        where P : Person,
        where PA: Payment,
        where S : Subscription
    {
        public void Save(P entity)
        {

        }

        public void Save(PA entity)
        {

        }

        public void Save(S entity)
        {

        }
    }

    public class Person
    {
        
    }

    public class Payment 
    {
        
    }
    public class Subscription
    {

    }

}
