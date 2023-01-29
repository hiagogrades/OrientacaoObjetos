using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Balta.ContentContext
{
    //Cria uma classe Aulas
    public class Lecture
    {
        //Define a ordem das aulas
        public int Ordem { get; set; }
        //Define o título da aula
        public string Title { get; set; }

        //Define a duração em minutos da aula
        public int DurationInMinutes { get; set; }
    }
}
