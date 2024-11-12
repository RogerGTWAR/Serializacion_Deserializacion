using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankLibrery
{
    public class FileRepository : IFileRepository
    {
        private StreamWriter? _fileWriter;
        private StreamReader? _fileReader;
        private FileStream? _fileStream;
        private string _fileName;
        public FileRepository(string fileName)
        {
            _fileName = fileName;
        }

        public void CloseFile()
        {
            try
            {
                _fileWriter?.Close();
                _fileReader?.Close();
            }
            catch (IOException)
            {
                throw new IOException("No se puede cerrar el archivo");
            }
        }

        public void Openfile()
        {

            try
            {
                _fileStream = new FileStream(_fileName, FileMode.Open,
                    FileAccess.Read);

                _fileReader = new StreamReader(_fileStream);
            }
            catch (IOException)
            {

                throw new IOException("Error al abrir el archivo");
            }
        }

        public void OpenOrCreateFile()
        {
            try
            {
                _fileStream = new FileStream(_fileName, FileMode.OpenOrCreate, FileAccess.Write);
                _fileWriter = new StreamWriter(_fileStream);
            }
            catch (IOException)
            {
                throw new IOException("Error al abrir el archivo");
            }
        }

        public string? ReadNextRecord()
        {
            try
            {
                return _fileReader?.ReadLine();
            }
            catch (IOException)
            {

                throw new IOException("Error al ller el archivo");
            }
        }

        public void ResetFilePointer()
        {
            try
            {
                _fileStream?.Seek(0, SeekOrigin.Begin);
            }
            catch (IOException)
            {

                throw new IOException("Error al restablecer el puntero del archivo");
            }
        }

        public void WriteRecordToFile(Record record)
        {
            try
            {
                _fileWriter?.WriteLine($"{record.Cuenta}, {record.Nombre}," +
                    $"{record.Apellido}, {record.Saldo}");
            }
            catch (IOException)
            {
                throw new IOException("Error al escribir en el archivo");
            }
        }
    }
}
