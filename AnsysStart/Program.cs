using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Ansys.Interop.ANSYSWB;

namespace AnsysStart
{
    class Program
    {
        static void Main(string[] args)
        {
            var wb = new WBClass();
            //wb.StartApplet = "AAOApplet"; 
            wb.Run();
        }
    }
}
