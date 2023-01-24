using System;

namespace OOComparandoObejetos
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var personA = new Person("Hiago Grades", 1);
            var personB = new Person("Hiago Grades", 1);

            //O resultado da equiparação sera falso.
            //Pois, os objetos são tratados como tipo de valor (class).
            //Ou seja, as classes não armazenam valores, armazenam suas referências.
            Console.WriteLine(personA == personB);

            //Equals => utilize-o para comparar objetos
            Console.WriteLine("Utilizando a interface Equatable");
            Console.WriteLine(personA.Equals(personB));
        }
    }

    public class Person : IEquatable<Person>
    {
        public Person(string name, int id)
        {
            Name = name;
            Id = id;
        }

        public string Name { get; set; }
        public int Id { get; set; }

        public bool Equals(Person person)
        {
            return Id == person.Id;
        }
    }
}
