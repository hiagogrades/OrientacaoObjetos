using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Balta.ContentContext
{
    public class CareerItem
    {
        //Define as propriedades da classe Itens da Carreira
        public int Ordem { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Course Course { get; set; }
    }
}
