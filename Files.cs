using System;
using System.Collections.Generic;
using System.Text;

namespace lab6.IFile
{
    class Files
    {
        private File[] _files;

        public Files(params File[] files)
        {
            if (files is not null)
            {
                _files = files;
            }
            else
            {
                _files = new File[0];
            }
        }

        public void Add(File file)
        {
            Array.Resize(ref _files, _files.Length + 1);
            _files[_files.Length -1 ] = file;
        }

        public void RemoveByIndex(int indexRemove)
        {
            if (indexRemove >= 0 && indexRemove < _files.Length)
            {
                File[] newFiles = new File[_files.Length - 1];
                for(int i=0, j=0; i< _files.Length; i++)
                {
                    if(i!= indexRemove)
                    {
                        newFiles[j] = _files[i];
                        j++;
                    }
                }
                _files = newFiles;
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
        }

        public void UpdateByIndex(File updateFile, int indexUpdate)
        {
            if (indexUpdate >= 0 && indexUpdate < _files.Length)
            {
                _files[indexUpdate] = updateFile;
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
        }

        public override string ToString()
        {
            String result = "";
            foreach(File file in _files)
            {
                result += file + "\n";
            }
            return result;
        }
    }
}
