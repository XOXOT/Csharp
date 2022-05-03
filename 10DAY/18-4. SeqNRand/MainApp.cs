using System;
using System.IO;

namespace SeqNRand
{
    class MainApp
    {
        static void Main(string[] args)
        {
            Stream outStream = new FileStream("a.dat", FileMode.Create);
            Console.WriteLine($"Position : {outStream.Position}");


            //순차접근
            outStream.WriteByte(0x01);
            Console.WriteLine($"Position : {outStream.Position}");

            outStream.WriteByte(0x02);
            Console.WriteLine($"Position : {outStream.Position}");

            outStream.WriteByte(0x03);
            Console.WriteLine($"Position : {outStream.Position}");

            //임의접근
            outStream.Seek(5, SeekOrigin.Current);
            Console.WriteLine($"Position : {outStream.Position}");
            
            //순차접근
            outStream.WriteByte(0x04);
            Console.WriteLine($"Position : {outStream.Position}");

            outStream.Close();
        }
    }
}
