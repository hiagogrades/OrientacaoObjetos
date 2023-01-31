using Balta.ContentContext.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Balta.ContentContext
{
    public class Course : Content
    {
        public Course()
        {
            //Inicializa a classe Module e Lecture
            Modules = new List<Module>();
            Lectures = new List<Lecture>(); 
        }
        public string Tag { get; set; }
        public IList<Module> Modules { get; set; } // Cria uma lista da classe Module
        public IList<Lecture> Lectures { get; set; } // Cria uma lista da classe Lectures

        //Define a duração em minutos da aula
        public int DurationInMinutes { get; set; }

        public EContentLevel Level { get; set; }
    }
}
