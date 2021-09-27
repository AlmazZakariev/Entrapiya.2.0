using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entrapiya._2._0
{
    class Element
    {
        public char Name { get; }
        public int Count { get; set; }
        public double Frequency { get; set; }
        public Element(char name)
        {
            Name = name;
            Count = 1;
        }
        public override string ToString()
        {
            return "Частота буквы " + Name +": " + Frequency;
        }
    }
    
}
