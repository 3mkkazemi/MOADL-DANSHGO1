using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            //محمد مهدی محمد کاظمی
            //تکلیف شماره3
            //‍‍‍‍پیشرفته1
            int[] grade = new int[10];
            double[] cofficient = new double[10];
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(" num {0}", i+1);
                grade[i] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(" cof {0}", i + 1);
                cofficient[i] = Convert.ToDouble(Console.ReadLine());
            }
            double Sum = 0;
            double Cofficient = 0;
            for (int i = 0; i <10; i++)
            {
                Sum += grade[i];
                Cofficient += cofficient[i];
            }
            double avrage = Sum / Cofficient;
            Console.WriteLine("میانگین کل"+avrage);
            Console.WriteLine("please enter any key to continue....");
            Console.ReadKey();
            

            
           
            
        }
    }
}
