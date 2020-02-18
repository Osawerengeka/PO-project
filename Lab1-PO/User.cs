using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Lab1_PO
{
    interface User
    {
          void readchat(StreamReader sr);
          void writemessage(StreamReader sr, StreamWriter sw);

    }
}
