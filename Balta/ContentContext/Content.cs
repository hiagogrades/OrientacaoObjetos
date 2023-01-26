using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Balta.ContentContext
{
    public abstract class Content
    {
        public Content()
        {
            //Centraliza criação do Id na classe Content
            //Fixa em um único ponto a possibilidade de errar 
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
    }
}
