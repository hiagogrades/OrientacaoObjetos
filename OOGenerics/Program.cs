﻿using System;
using System.ComponentModel.DataAnnotations;

namespace OOGenerics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var context = new DataContext<Person>();
            var person = new Person();
            context.Save(person); //Salvando uma pessoa
        }
    }

    //Para dizer que uma classe é genérica em C#, utilize os sinais (<>);
    //Como por exemplo <TipoDaClasse>
    //DataContext<T>
    public class DataContext<T>
    {
        //Método para salvar as informações
        public void Save(T entity)
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
