using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Balta.ContentContext
{
    public class Module
    {
        //Cria a classe construtora Module
        public Module()
        {
            Lectures = new List<Lecture>();
        }

        //Define uma propriedade Order, do tipo inteira
        public int Order { get; set; }

        //Define uma propriedade Titulo, do tipo string 
        public string Title { get; set; }

        //Define uma propriedade Lectures, do Tipo lista de Lecture
        public IList<Lecture> Lectures { get; set; }

    }
}
