using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP___G2___Assignment_1.UserDefine
{
    internal struct MyStruct
    {

        // we can write 
        //attribute
        int myattribute;  //defult=>private 
        // 2-function
        internal void myfunction()
        {
            Console.WriteLine("hi");

        }
        //3-property
        public int myproperty { get; set; }

        //4-event  
    }
}
