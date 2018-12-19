using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListTest
{
    public class ExampleClassTest
    {
        private int exampleInt;

        public int ExampleInt { get { return exampleInt; } set { exampleInt = value; } }

        public ExampleClassTest(int ExampleInt)
        {
            this.ExampleInt = ExampleInt;
        }

        public override string ToString()
        {
            return base.ToString() + ": " + exampleInt.ToString();
        }
    }
}
