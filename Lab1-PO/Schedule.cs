using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime;
namespace Lab1_PO
{
    
    public  class Schedule 
    {
        public struct evnt
        {
            int day;
            int month;
            string def;
            public evnt(int day, int month, string def)
            {
                this.day = day;
                this.month = month;
                this.def = def;          
            }
        }
        public static List<evnt> sch = new List<evnt>(12);

        public void addEvent(evnt e)
        {           
            sch.Add(e);    
        }
    }
}
