using Balta.ContentContext;
using System;
using System.Collections.Generic;

namespace Balta
{
    internal class Program
    {
        static void Main(string[] args)
        {
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
        }
    }
}
