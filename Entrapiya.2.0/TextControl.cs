using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entrapiya._2._0
{
    class TextControl
    {
        private List<Element> Letters = new List<Element>();
        private int NumberOfAllSymbols { get; }
        private int NumberOfUniqueSymbols { get; }
        private double Entrapia {get; set;}
        public TextControl(string fileName)
        {
            var text = new Text(fileName);
            char[] TextChars = text.ResearchText.ToCharArray();
            Letters.Add(new Element(TextChars[0]));
            NumberOfAllSymbols = TextChars.Length;
            for (int i = 1; i < TextChars.Length; i++)
            {
                bool have = false;
                for (int j = 0; j < Letters.Count; j++)
                {
                    if (TextChars[i] == Letters[j].Name)
                    {
                        have = true;
                        Letters[j].Count++;
                        break;
                    }
                }
                if (have == false)
                {
                    {
                        Letters.Add(new Element(TextChars[i]));
                    }
                }
            }
            NumberOfUniqueSymbols = Letters.Count();
        }
        public double EntrapiaCalculation()
        {
            for (int i = 0; i < NumberOfUniqueSymbols; i++)
            {
                double a = Math.Round((double)Letters[i].Count / NumberOfAllSymbols, 8);
                Entrapia += Math.Round(a * Math.Round((double)Math.Log(a, 2), 1), 5);                             
            }
            Entrapia = Math.Abs(Entrapia);
            return Entrapia;
            
        }
        public string FrequencyCalculation()
        {
            string result = "";         
            for (int i = 0; i < Letters.Count; i++)
            {
                Letters[i].Frequency = (double)Letters[i].Count / NumberOfAllSymbols;
                result += Letters[i] + "\n";
            }
            return result;
        }
    }
}
