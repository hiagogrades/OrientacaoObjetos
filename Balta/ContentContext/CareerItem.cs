using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Balta.ContentContext
{
    public class CareerItem
    {
        public CareerItem(int order, string title, string description, Course course)
        {
            //Verifica se o curso é nulo. Se for, dispara uma exception
            if (course == null)
                throw new System.Exception("O curso não pode ser nulo");

            Order = order;
            Title = title;
            Description = description;
            Course = course;
        }

        //Define as propriedades da classe Itens da Carreira
        public int Order { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Course Course { get; set; }
    }
}
