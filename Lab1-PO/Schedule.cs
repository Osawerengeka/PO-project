using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime;
namespace Lab1_PO
{
    class Schedule 
    {
        struct evnt
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
        List<evnt> sch = new List<evnt>(12);

        void addEvent(int day, int month, string def)
        {
            evnt e = new evnt(day,month,def);
            sch.Add(e);    
        }
    }
}
