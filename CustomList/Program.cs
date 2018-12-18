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
            CustomList<int> intList = new CustomList<int>();
            intList.Add(1);
            intList.Add(2);
            intList.Add(3);
            intList.Add(4);
            intList.Add(5);
            intList.Add(6);
            intList.Add(7);
            intList.Add(8);
            intList.Add(9);
            intList.Add(10);
            intList.Add(11);
            intList.Add(12);

            intList.Remove(7);
            intList.Remove(8);
            intList.Remove(9);
            intList.Remove(10);
            intList.Remove(11);


            for (int i = 0; i < intList.Count; i++)
            {
                Console.WriteLine(intList[i]);
            }

            Console.WriteLine("");

            Console.WriteLine(intList.Count);
            Console.WriteLine(intList.Capacity);

            Console.ReadLine();
        }
    }
}
