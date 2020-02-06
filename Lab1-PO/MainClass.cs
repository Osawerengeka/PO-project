using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace Lab1_PO
{
    class MainClass
    {
        StreamWriter sw = new StreamWriter("Users.txt", false, System.Text.Encoding.Default);
        StreamReader sr = new StreamReader("Users.txt", System.Text.Encoding.Default);

        string login;
        User u;

        bool IsUnic(string str)
        {
            while (sr.EndOfStream == false)
                if (sr.ReadLine().Contains(str))
                {
                    Console.WriteLine("Invalid Login: ");
                    return false;
                }
            return true;
        }

        int hashfunc(string pass)
        {

            return 0;

        }
       public void Register()
        {
            List <string> accs = new List<string>();
            Console.WriteLine("Create Login: ");
            string log = Console.ReadLine();
            if(IsUnic(log))
            {
                Console.WriteLine("Create Password");
                string pass = Console.ReadLine();
                int hash = hashfunc(pass);
                sw.WriteLine(log +" "+ hash.ToString());
                Console.WriteLine("Acc has created succesfully");
            }
        }
        public bool Auth()
        {

            Console.WriteLine("Login: ");
            string log = Console.ReadLine();
            Console.WriteLine("Password:");
            string pass = Console.ReadLine();
            int hash = hashfunc(pass);
            if (IsUnic(pass + hash.ToString()))
            {
                return true;
            }
            else
                return false;

        }
        void Startmenu()
        {
            ConsoleKeyInfo comm = Console.ReadKey();
            if ('a' == comm.KeyChar)
            {
                Auth();
            }
            else Register();
            comm = Console.ReadKey();
            if ('n' == comm.KeyChar)
            {
                u.GetNotification();

            }
            if ('d' == comm.KeyChar)
            {
                u.openchats();

            }
        }
        public  void Main()
        {
            Startmenu();
            
        }
    }
}
