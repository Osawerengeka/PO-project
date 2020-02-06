using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_PO
{
    interface User
    {
       Schedule sch{ get; }

        public Schedule GetNotification();

        public void openchats();
        
    }
}
