using System;
using CustomListProgram;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CustomListTest
{
    [TestClass]
    public class CustomList
    {
        [TestMethod]
        public void Add_Int_AddIntegerToList()
        {
            int exampleInt = 5;
            CustomList<int> intList = new CustomList<int>();

            intList.Add(exampleInt);

            Assert.AreEqual(intList[0], exampleInt);
        }

        [TestMethod]
        public void Add_String_AddStringToList()
        {
            string exampleString = "Hello";
            CustomList<string> stringList = new CustomList<string>();

            stringList.Add(exampleString);

            Assert.AreEqual(stringList[0], "Hello");
        }

        [TestMethod]
        public void Add_Object_AddObjectToList()
        {
            ExampleClass exampleObj = new ExampleClass(1);
            CustomList<ExampleClass> objList = new CustomList<ExampleClass>();

            objList.Add(exampleObj);

            Assert.AreEqual(objList[0].ExampleValue, 1);
        }

        [TestMethod]
        public void Add_FiveEntries_CountEqualsFive()
        {
            string exampleString = "Hello";
            CustomList<string> exampleList = new CustomList<string>();

            exampleList.Add(exampleString);
            exampleList.Add(exampleString);
            exampleList.Add(exampleString);
            exampleList.Add(exampleString);
            exampleList.Add(exampleString);


            Assert.AreEqual(exampleList.Count, 5);
        }

        [TestMethod]
        public void Add_FiveEntries_PreviousEntriesExist()
        {
            string exampleString = "Hello";
            CustomList<string> exampleList = new CustomList<string>();

            exampleList.Add(exampleString);
            exampleList.Add(exampleString);
            exampleList.Add(exampleString);
            exampleList.Add(exampleString);
            exampleList.Add(exampleString);


            Assert.AreEqual(exampleList[2], exampleString);
        }

        [TestMethod]
        public void Add_ThreeEntries_ThirdEntryEquals1()
        {
            int exampleInt = 1;
            CustomList<int> exampleList = new CustomList<int>();

            exampleList.Add(exampleInt);
            exampleList.Add(exampleInt);
            exampleList.Add(exampleInt);


            Assert.AreEqual(exampleList[2], 1);
        }

        [TestMethod]
        public void Add_NoEntries_CountEqualsZero()
        {
            //string exampleString = "Hello";
            CustomList<string> exampleList = new CustomList<string>();

            //exampleList.Add(exampleString);

            Assert.AreEqual(exampleList.Count, 0);
        }

        [TestMethod]
        public void Remove_String_RemoveStringsFromList()
        {
            string exampleString = "Hello";
            CustomList<string> stringList = new CustomList<string>();

            stringList.Add(exampleString);
            stringList.Add(exampleString);
            stringList.Add(exampleString);
            stringList.Add(exampleString);
            stringList.Add(exampleString);

            stringList.Remove(exampleString);

            Assert.AreNotEqual(stringList[4], exampleString);
        }

        [TestMethod]
        public void Remove_Zero_RemoveZeroFromNumList()
        {
            CustomList<int> numList = new CustomList<int>();

            numList.Add(1);
            numList.Add(2);
            numList.Add(0);
            numList.Add(3);
            numList.Add(4);

            numList.Remove(0);

            Assert.AreNotEqual(numList[2], 0);
        }

        [TestMethod]
        public void Remove_Object_RemoveObjectFromList()
        {
            ExampleClass exampleObj1 = new ExampleClass(1);
            ExampleClass exampleObj2 = new ExampleClass(2);
            ExampleClass exampleObj3 = new ExampleClass(3);
            ExampleClass exampleObj4 = new ExampleClass(4);
            ExampleClass exampleObj5 = new ExampleClass(5);

            CustomList<ExampleClass> objList = new CustomList<ExampleClass>();

            objList.Add(exampleObj1);
            objList.Add(exampleObj2);
            objList.Add(exampleObj3);
            objList.Add(exampleObj4);
            objList.Add(exampleObj5);

            objList.Remove(exampleObj3);

            Assert.AreNotEqual(objList[2].ExampleValue, 3);
        }
    }
}
