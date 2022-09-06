using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ResultsTask2
{
    class GetSize
    {
        static long count = 0;
        public static long GetSizeDir(string path)
        {

            DirectoryInfo fileAndDirectory = new DirectoryInfo(path);


            if (!fileAndDirectory.Exists)
            {
                Console.WriteLine("папка по заданному адресу не существует");
                return 0;
            }
            else
            {
                try
                {
                    foreach (FileInfo f in fileAndDirectory.GetFiles())
                    {

                        GetSize.count = (long)(count + f.Length);
                    }

                    foreach (DirectoryInfo d in fileAndDirectory.GetDirectories())
                    {
                        GetSizeDir(d.FullName);
                    }
                }

                catch(Exception ex)
                {
                    Console.WriteLine("Ошибка: ", ex.Message);
                }
            }

            return count;

        }
    }
}
