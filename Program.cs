using System;

namespace ResultsTask2
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"E:\in\";
            
            Console.WriteLine($"Размер папки: {GetSize.GetSizeDir(path)} байт");
        }
    }
}
