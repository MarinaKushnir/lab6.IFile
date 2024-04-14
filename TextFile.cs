using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6.IFile
{
    public class TextFile : File
    {
        private string _author;
        private string _type;
        private int _wordCount;
        static readonly int MAX_WordCount = 100000;
        public int WordCount
        {
            get => _wordCount;
            set => _wordCount = value > 0 && value < MAX_WordCount ? value : throw new System.ArgumentOutOfRangeException();
        }
        public string Author
        {
            get => _author;
            set
            {
                string valueTrim = value.Trim();
                if (!string.IsNullOrEmpty(value) && valueTrim.Length > 1)
                {
                    _author = valueTrim;
                }
                else
                {
                    throw new ArgumentNullException();
                }
            }
        }

        public string Type
        {
            get => _type;
            set
            {
                string valueTrim = value.Trim();
                if (!string.IsNullOrEmpty(value) && valueTrim.Length > 1)
                {
                    _type = valueTrim;
                }
                else
                {
                    throw new ArgumentNullException();
                }
            }
        }


        public TextFile(string fileName, string author, string type, int wordCount) : base(fileName)
        {
            Author = author;
            Type = type;
            WordCount = wordCount;
        }

        public override string ToString()
        {
            return base.ToString() + $"{base.ToString()} \n Автор файла: {Author};\n Тип: {Type};\n Количество слов: {WordCount}";
        }
    }
}
