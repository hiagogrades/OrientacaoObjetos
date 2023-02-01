using Balta.ContentContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Balta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            //Criando uma nova lista de artigos
            var articles = new List<Article>();

            //Adiciona um novo artigo 
            articles.Add(new Article("Artigo Sobre OOP", "orientacao-objetos"));
            articles.Add(new Article("Artigo Sobre C#", "CSharp"));
            articles.Add(new Article("Artigo Sobre .Net", "DotNet"));

            //Imprime cada item da lista no console
            foreach (var article in articles)
            {
                Console.WriteLine(article.Id);
                Console.WriteLine(article.Title);
                Console.WriteLine(article.Url);
            }

            //Inicializa uma lista de Course
            var courses = new List<Course>();
            
            //Cria novos curlos 
            var courseOOP = new Course("Fundamentos OOP", "Fundamentos-oop");
            var courseCsharp = new Course("Fundamentos C#", "Fundamentos-Csharp");
            var courseAspNet = new Course("Fundamentos ASP.NET", "Fundamentos-Asp.Net");

            //Adiciona os novos cursos para a lista de Course
            courses.Add(courseOOP);
            courses.Add(courseCsharp);
            courses.Add(courseAspNet);

            //Inicia uma lista de carreiras
            var careers = new List<Career>();

            //Cria uma nova carreira
            var careerDotNet = new Career("Especialista .NET", "especialista-dotnet");
            //Adiciona um novo item para carreira
            var careerItem2 = new CareerItem(2, "Aprenda .OOP", "", courseOOP);
            var careerItem = new CareerItem(1, "Comece por aqui", "", courseCsharp);
            var careerItem3 = new CareerItem(3, "Aprenda .Net", "", courseAspNet);

            //Adiciona um item para a carreira 
            careerDotNet.Items.Add(careerItem2);
            careerDotNet.Items.Add(careerItem);
            careerDotNet.Items.Add(careerItem3);

            //Adiciona uma carreira
            careers.Add(careerDotNet);

            //Percorre todos os itens de careers
            foreach (var career in careers)
            {
                //Imprime o título da carreira
                Console.WriteLine(career.Title);
                
                //Percorre todos os itens de carreira e ordena pelo pela propriedade order 
                foreach (var item in career.Items.OrderBy(x => x.Order))
                {
                    //Imprime os itens da carreira
                    Console.WriteLine($"{item.Order} - {item.Title}");
                    Console.WriteLine(item.Course.Title);
                    Console.WriteLine(item.Course.Level);
                }
            }
        }
    }
}
