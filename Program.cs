using System;
using System.IO;

namespace Object_Printer_upd
{  

    class PrintText
    {
        public static string EnterPrintText_1()
        {
            string Text;
            Text = Console.ReadLine();
            return Text;
        }

    }

    class CreateFile
    {
        public static void CreateTXT()
        {
            Console.Write("\n\nВведите текст для записи в файл. К нему будет добавлена дата и время. \t");
            using (StreamWriter outfile = new StreamWriter(@"C:\temp.txt"))
                //(@"C:\Users\ivan.melnyk\Desktop\Temp\temp.txt")
            {
                outfile.Write(PrintText.EnterPrintText_1() + " в " + DateTime.Now.ToString());
            }
        }
    }

    class ReadFromFile
    {
        public static void ReadFF()
        {
            string path = @"C:\temp.txt";

            string[] readText = File.ReadAllLines(path);
            foreach (string TextFromFile in readText)
            {
                Console.WriteLine("\nТекст из данного файла: " + TextFromFile);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите текст, который необходимо вывести на экран: \t");
            Console.Write("\n" + "Введенный текст:\t" + PrintText.EnterPrintText_1() + "\n");
            CreateFile.CreateTXT();
            Console.WriteLine("\nТекстовый файл с текстом создан по адресу C:/" +"\n");
            ReadFromFile.ReadFF();
            Console.ReadLine();
        }
    }
}