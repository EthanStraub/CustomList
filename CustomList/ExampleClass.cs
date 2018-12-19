using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListProgram
{
    public class ExampleClass
    {
        private int exampleValue;
        public int ExampleValue { get { return exampleValue; } set { exampleValue = value; } }

        public ExampleClass(int ExampleValue)
        {
            this.ExampleValue = ExampleValue;
        }

        public override string ToString()
        {
            return base.ToString() + ": " + exampleValue.ToString();
        }
    }
}
