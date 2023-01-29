using Balta.ContentContext;
using System;

namespace Balta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Instancia o obejeto Course
            var course = new Course();
            //Atribui o nível iniciante (Beginner), para o curso.
            course.Level = ContentContext.Enums.EContentLevel.Beginner;

            foreach(var item in course.Modules)
            {

            }
            
        }
    }
}
