using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        public void abc()
        {
            string str = "helloABworld";
            string str1 = "c";
            string str2 = "";
            string str3 = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != 'A')
                {
                    str2 = str2 + str[i];
                    
                }
                else
                {
                    //str2 = "";
                    Console.WriteLine(str2);
                }
                
            }
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.abc();
            Console.ReadLine();
        }
    }
}
