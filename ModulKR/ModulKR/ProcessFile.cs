using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ModulKR
{
    internal class ProcessFile
    {
        private TextOperation _textOperation = new TextOperation();

        public void Process(string filePath, string outputPath, TextOperation.TextOperationDelegate textOperationDelegate)
        {
            try
            {
                using (FileStream read = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                using (StreamReader reader = new StreamReader(read))
                {
                    string content;

                    while ((content = reader.ReadLine()) != null)
                    {
                        string result = textOperationDelegate(content);
                        Console.WriteLine(result);
                        FileWriter(outputPath, result);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Помилка при обробці файлу: {ex.Message}");
            }
        }

            private void FileWriter(string outputPath, string content)
            {
                try
                {
                    using (FileStream write = new FileStream(outputPath, FileMode.Append, FileAccess.Write))
                    using (StreamWriter writer = new StreamWriter(write))
                    {
                        writer.WriteLine(content);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Помилка при записі у файл: {ex.Message}");
            }
        }
    }
}
