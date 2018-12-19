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


            ExampleClass Example1 = new ExampleClass(1, "HELLO");
            ExampleClass Example2 = new ExampleClass(2, "WORLD");

            CustomList<ExampleClass> exampleList1 = new CustomList<ExampleClass>();
            CustomList<ExampleClass> exampleList2 = new CustomList<ExampleClass>();

            exampleList1.Add(Example1);
            exampleList2.Add(Example2);
            
            Console.WriteLine(exampleList1.Zip(exampleList2));

            Console.ReadLine();
        }
    }
}
