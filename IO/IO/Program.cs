﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace IO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(File.Exists(@"C:\HelloIO\IO.txt"));
            Console.WriteLine(Directory.Exists(@"C:\"));

            string path = ".";
            if (args.Length > 0)
            {
                if (Directory.Exists(args[0]))
                { path = args[0]; }
                else
                {
                    Console.WriteLine("{0} not found;using current directory:", args[0]);
                }
            } 
            DirectoryInfo dir = new DirectoryInfo(path);
            foreach (FileInfo f in dir.GetFiles("*.exe"))
            {
                string name = f.Name;
                long size = f.Length;
                DateTime creationTime = f.CreationTime;
                Console.WriteLine("{0, -12:N0}{1,-20:g}{2}",size,creationTime,name);
            }
            Console.Read();
        }
    }
}
