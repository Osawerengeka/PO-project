using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace Lab1_PO
{
    public class MainClass
    {
        StreamWriter sw = new StreamWriter("Users.txt", false, System.Text.Encoding.Default);
        StreamReader sr = new StreamReader("Users.txt", System.Text.Encoding.Default);
        string login;
        User u;
        
        public bool IsUnic(string str)
        {
            while (sr.EndOfStream == false)
                if (sr.ReadLine().Contains(str))
                {
                    Console.WriteLine("Invalid Login: ");
                    return false;
                }
            return true;
        }
        public string Info(string str)
        {
                while (sr.EndOfStream == false)
                {
                string s=sr.ReadLine();
                if (s.Contains(str))
                {
                    return s;
                }
                }
            return null;
        }
        
        public int hashfunc(string pass)
        {
            int hash = 0;
            for (int i = 1; i < pass.Length; i++)
			{
                hash = hash + pass[i] * pass[0];

			}
            return hash;

        }
        public void Register(string log,string pass)
        {
            List <string> accs = new List<string>();
            if(IsUnic(log))
            {       
                int hash = hashfunc(pass);
                string role = Console.ReadLine();
                sw.WriteLine(log + " " + hash.ToString() + " " + role );
                Console.WriteLine("Acc has created succesfully");
            }
        }
        public bool Auth(string login,string pass)
        {
            int hash = hashfunc(pass);
            if (IsUnic(login + hash.ToString()))
            {
                string s = Info(login + hash.ToString());
                if(s.Contains("Teacher"))
                {   
                    u = new Teacher();                           
                }
                else
                    u = new Student();
                return true;
            }
            else
                return false;

        }
        public void Startmenu(string login,string pass,string func , string isunum)
        {
               
            if(func.Contains("reg"))
            {
             Register(login,pass);
            }
            else
            if(Auth(login,pass))
            {
                if(func.Contains("read"))    
                {
                    using(StreamWriter sw = new StreamWriter(isunum + ".txt", false, System.Text.Encoding.Default))
                        
                    using(StreamReader sr = new StreamReader(isunum + ".txt", System.Text.Encoding.Default))
                    u.readchat(sr);                       
                }
                if (func.Contains("write"))
                {
                    using (StreamWriter sw = new StreamWriter(isunum + ".txt", false, System.Text.Encoding.Default))

                    using (StreamReader sr = new StreamReader(isunum + ".txt", System.Text.Encoding.Default))
                        u.writemessage(sr,sw);
                }
            }
        }
        
         public void  Main(string [] args)
        {

            Startmenu(args[0],args[1],args[2],args[3]);   
        }
        
    }
}
