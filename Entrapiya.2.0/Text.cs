using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Entrapiya._2._0
{
    public class Text
    {
        public string ResearchText { get; }
        public string FileName { get;}
        public Text(string fileName)
        {
            if (string.IsNullOrWhiteSpace(fileName))
            {
                throw new ArgumentException("Ссылка не может быть пустой", fileName);
            }
            FileName = fileName;
            string text = "";
            using (StreamReader sr = new StreamReader(FileName))
            {
                text = sr.ReadToEnd();
            }
            if (string.IsNullOrWhiteSpace(text))
            {
                throw new ArgumentException("Задан пустой текст или неверная ссылка на файл");
            }
            ResearchText = ReplaceSymbols(text);
        }

        private string ReplaceSymbols(string researchText)
        {
            researchText = Regex.Replace(researchText, "[^а-яА-Я ]", "");
            researchText = researchText.ToLower();
            using (var fs = new FileStream("ChangedText.txt", FileMode.OpenOrCreate))
            {
                var sw = new StreamWriter(fs);
                sw.Write(researchText);
            }
            return researchText;
        }
         

    }
}
