using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace IOWrite
{
    class Program
    {
        private const string FILE_NAME = "Test.txt";
        static void Main(string[] args)
        {
            //if (File.Exists(FILE_NAME))
            //{
            //    Console.Write("{0} already exists!",FILE_NAME);
            //    Console.Read();
            //    return;
            //}
            //FileStream fs = new FileStream(FILE_NAME,FileMode.Create);
            //BinaryWriter w = new BinaryWriter(fs);
            //for (int i = 0; i < 11; i++)
            //{
            //    w.Write("a");
            //}
            //w.Close();
            //fs.Close();


            using (StreamWriter w = File.AppendText("test.txt"))
            {
                Log("hehe",w);
                Log("wzp",w);
                w.Close();
            }
        }

        public static void Log(string logMessage,TextWriter w)
        {
            w.Write("\r\nLog Entry:");
            w.WriteLine(":{0}",logMessage);
            w.Flush();
        }
    }
}
