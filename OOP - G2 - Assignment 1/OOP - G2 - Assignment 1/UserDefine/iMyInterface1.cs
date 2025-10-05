using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP___G2___Assignment_1.UserDefine
{
    internal interface iMyInterface1
    {

        //we write in
        //1- signture of method
        public void Myfunction();

        //2-  signture of property
        public int MyProperty {  get; set; }
        // until C#7


        //3- fully implemnted method == > C#8
        //can be privet
        public void MyFunction2()
        {
            Console.WriteLine("hi");
        
        }

    }
}
