using System;
using System.Linq;
using System.IO;

namespace Dir
{
    class MainApp
    {
        static void Main(string[] args)
        {
            string directory;
            if (args.Length < 1)
                directory = "."; //상대 경로
            else
                directory = args[0];

            Console.WriteLine($"{directory} directory Info");
            Console.WriteLine("- Directories :");
            //linq 쿼리식 디렉토리
            var directories = (from dir in Directory.GetDirectories(directory)
                         let info = new DirectoryInfo(dir)
                         select new
                         {
                             Name = info.Name,
                             Attributes = info.Attributes
                         }).ToList();

            foreach (var d in directories)
                Console.WriteLine($"{d.Name} : {d.Attributes}");

            Console.WriteLine("- Files :");
            //linq 쿼리식 파일
            var files = (from file in Directory.GetFiles(directory)
                         let info = new FileInfo(file)
                              select new
                              {
                                  Name = info.Name,
                                  FileSize = info.Length,
                                  Attributes = info.Attributes
                              }).ToList();
            foreach (var f in files)
                Console.WriteLine(
                    $"{f.Name} : {f.FileSize}, {f.Attributes}");
        }
    }
}
