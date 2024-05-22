using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_KlocworkTest
{
    internal class Service
    {
        public static DateTime TestInstance;
        public Service()
        {
            if(TestInstance == null)
            {
                TestInstance = DateTime.Now;
            }
        }
       
    }

}
