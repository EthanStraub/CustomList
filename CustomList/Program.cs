using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListProgram
{
    class Program
    {
        static void Main(string[] args)
        {


            CustomList<int> intTest1 = new CustomList<int>() { 5, 5, 5, 5, 1 };
            CustomList<int> intTest2 = new CustomList<int>() { 1, 1, 1, 6 };

            intTest1 -= intTest2;

            Console.WriteLine(intTest1);


            Console.ReadLine();
        }
    }
}
