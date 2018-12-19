using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListProgram
{
    public class ExampleClass
    {
        private int exampleInt;
        private string exampleString;

        public int ExampleInt { get { return exampleInt; } set { exampleInt = value; } }
        public string ExampleString { get { return exampleString; } set { exampleString = value; } }

        public ExampleClass(int ExampleInt, string ExampleString)
        {
            this.ExampleInt = ExampleInt;
            this.ExampleString = ExampleString;
        }

        public override string ToString()
        {
            return base.ToString() + ": " + exampleInt.ToString() + ", " + exampleString;
        } 
    }
}
