using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gugudan
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int a = 1; a < 10; a++)
            {
                Console.WriteLine("\n" + "    " + a + "단 입니다");
                for(int b = 1; b < 10; b++)
                {
                    Console.WriteLine(a + " 곱하기 " + b + "는 " + a * b + "입니다");
                }
                
            }


        }
    }
}
