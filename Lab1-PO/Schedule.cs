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
            public int day { get; }
            public int month { get; }
            public string def { get; }
            public evnt(int day, int month, string def)
            {
                this.day = day;
                this.month = month;
                this.def = def;          
            }
        }
        public HashSet<evnt> sch = new HashSet<evnt>(12);
        
        public void addEvent(evnt e)
        {           
            
            sch.Add(e);    
        }
 
    }
}
