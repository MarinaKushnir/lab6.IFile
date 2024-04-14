using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6.IFile
{
    public abstract class File : IFile
    {
        private readonly string _fileName;
        private File _file;
        private string _currentAction;

        public File(string fileName)
        {
            CurrentAction = Action.STAND;
            FileName = fileName;
        }
        public string FileName
        {
            get => _fileName;
            init
            {
                string valueTrim = value.Trim();
                if (!string.IsNullOrEmpty(value) && valueTrim.Length > 1)
                {
                    _fileName = valueTrim;
                }
                else
                {
                    throw new ArgumentNullException();
                }
            }
            
        }

        private string CurrentAction
        {
            get => _currentAction;
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _currentAction = value.Trim();
                }
                else
                {
                    throw new ArgumentNullException();
                }
            }

        }


        public void Open()
        {
            if(CurrentAction != Action.OPEN)
            {
                CurrentAction = Action.OPEN;
            }
        }

        public void Save()
        {
            if (CurrentAction != Action.SAVE)
            {
                CurrentAction = Action.SAVE;
            }
        }
        public void Close()
        {
            if (CurrentAction != Action.CLOSE)
            {
                CurrentAction = Action.CLOSE;
            }
        }

        public override string ToString()
        {
            return $"Файл \n Имя файла: {FileName};\n Действие: {CurrentAction}";
        }
    }
}
