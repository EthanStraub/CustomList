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

            CustomList<int> testInt1 = new CustomList<int>();
            CustomList<int> testInt2 = new CustomList<int>();


            //CustomList<ExampleClass> objList = new CustomList<ExampleClass>();

            testInt1.Add(10);
            testInt1.Add(30);
            testInt1.Add(50);

            testInt2.Add(20);
            testInt2.Add(40);
            testInt2.Add(60);

            testInt1.Zip(testInt2);

            Console.WriteLine(testInt1);

            Console.ReadLine();
        }
    }
}
