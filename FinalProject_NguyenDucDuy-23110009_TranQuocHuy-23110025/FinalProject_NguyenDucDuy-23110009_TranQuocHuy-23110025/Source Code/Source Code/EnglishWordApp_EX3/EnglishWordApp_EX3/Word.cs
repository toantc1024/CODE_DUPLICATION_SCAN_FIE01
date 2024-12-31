using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishWordApp_EX3
{
    public class Word
    {
        private string nameWord;
        private string typeOfWord;
        public string NameWord { get => nameWord; set => nameWord = value; }
        public string TypeOfWord { get=> typeOfWord; set => typeOfWord = value; }
        public Word(string nameWord, string typeOfWord)
        {
            NameWord = nameWord;
            TypeOfWord = typeOfWord;
        }
    }
}
