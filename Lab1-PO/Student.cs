using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_PO
{
    class Student : User
    {
        public Schedule sch => throw new NotImplementedException();

        public Schedule GetNotification()
        {
            return 0;
        }

        public void openchats()
        {
           
        }
    }
}
