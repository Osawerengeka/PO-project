using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace Lab1_PO
{
    public class Teacher : User
    {
        public void readchat(StreamReader sr)
        {
            while (sr.EndOfStream == false)
            {
                 string s = sr.ReadLine();
                Console.WriteLine(s);
            }

        }
        public void writemessage(StreamReader sr, StreamWriter sw)
        {
            readchat(sr);
            string s = Console.ReadLine();
            sw.WriteLine("T:" + " " + s);
        }

    }
}
