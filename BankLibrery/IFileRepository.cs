using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankLibrery
{
    public interface IFileRepository
    {
        void OpenOrCreateFile();
        void Openfile();
        void WriteRecordToFile(Record record);
        string? ReadNextRecord();
        void ResetFilePointer();
        void CloseFile();
    }
}
