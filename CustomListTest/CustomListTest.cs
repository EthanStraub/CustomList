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
            ExampleClassTest exampleObj = new ExampleClassTest(1);
            CustomList<ExampleClassTest> objList = new CustomList<ExampleClassTest>();

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
            ExampleClassTest exampleObj1 = new ExampleClassTest(1);
            ExampleClassTest exampleObj2 = new ExampleClassTest(2);
            ExampleClassTest exampleObj3 = new ExampleClassTest(3);
            ExampleClassTest exampleObj4 = new ExampleClassTest(4);
            ExampleClassTest exampleObj5 = new ExampleClassTest(5);

            CustomList<ExampleClassTest> objList = new CustomList<ExampleClassTest>();

            objList.Add(exampleObj1);
            objList.Add(exampleObj2);
            objList.Add(exampleObj3);
            objList.Add(exampleObj4);
            objList.Add(exampleObj5);

            objList.Remove(exampleObj3);

            Assert.AreNotEqual(objList[2].ExampleValue, 3);
        }

        [TestMethod]
        public void ToString_Integers_ConvertIntegersToString()
        {
            int exampleInt = 1234;
            string convertedInt;
            CustomList<int> exampleList = new CustomList<int>();

            exampleList.Add(exampleInt);

            convertedInt = exampleList.ToString();

            Assert.AreEqual(convertedInt, "1234");
        }

        [TestMethod]
        public void ToString_Objects_ConvertObjects()
        {
            string convertedObjList;

            ExampleClassTest exampleObj1 = new ExampleClassTest(10);
            ExampleClassTest exampleObj2 = new ExampleClassTest(20);
            ExampleClassTest exampleObj3 = new ExampleClassTest(30);
            ExampleClassTest exampleObj4 = new ExampleClassTest(40);
            ExampleClassTest exampleObj5 = new ExampleClassTest(50);

            CustomList<ExampleClassTest> objList = new CustomList<ExampleClassTest>();

            objList.Add(exampleObj1);
            objList.Add(exampleObj2);
            objList.Add(exampleObj3);
            objList.Add(exampleObj4);
            objList.Add(exampleObj5);

            objList.Remove(exampleObj3);

            convertedObjList = objList.ToString();

            Assert.AreEqual(convertedObjList, "CustomListTest.ExampleClassTest: 10, CustomListTest.ExampleClassTest: 20, CustomListTest.ExampleClassTest: 40, CustomListTest.ExampleClassTest: 50");
        }

        [TestMethod]
        public void OverloadPlus_TwoStringLists_AddListsTogether()
        {
            string dualListString;
            CustomList<string> dualList;

            CustomList<string> testStrings1 = new CustomList<string>();
            CustomList<string> testStrings2 = new CustomList<string>();

            testStrings1.Add("Hello");
            testStrings1.Add("World");

            testStrings2.Add("This");
            testStrings2.Add("should");
            testStrings2.Add("work");

            dualList = testStrings1 + testStrings2;
            dualListString = dualList.ToString();

            Assert.AreEqual(dualListString, "Hello, World, This, should, work");
        }

        [TestMethod]
        public void OverloadPlus_TwoIntLists_AddListsTogether()
        {
            string dualListString;
            CustomList<int> dualList;

            CustomList<int> testInts1 = new CustomList<int>();
            CustomList<int> testInts2 = new CustomList<int>();

            testInts1.Add(1);
            testInts1.Add(3);

            testInts2.Add(5);
            testInts2.Add(6);
            testInts2.Add(7);

            dualList = testInts1 + testInts2;
            dualListString = dualList.ToString();

            Assert.AreEqual(dualListString, "1, 3, 5, 6, 7");
        }

        [TestMethod]
        public void OverloadPlus_TwoObjLists_AddListsTogether()
        {
            string dualListString;
            CustomList<ExampleClassTest> dualList;

            CustomList<ExampleClassTest> testObjs1 = new CustomList<ExampleClassTest>();
            CustomList<ExampleClassTest> testObjs2 = new CustomList<ExampleClassTest>();

            ExampleClassTest exampleObj1 = new ExampleClassTest(10);
            ExampleClassTest exampleObj2 = new ExampleClassTest(20);

            ExampleClassTest exampleObj3 = new ExampleClassTest(30);
            ExampleClassTest exampleObj4 = new ExampleClassTest(40);
            ExampleClassTest exampleObj5 = new ExampleClassTest(50);

            testObjs1.Add(exampleObj1);
            testObjs1.Add(exampleObj2);

            testObjs2.Add(exampleObj3);
            testObjs2.Add(exampleObj4);
            testObjs2.Add(exampleObj5);

            dualList = testObjs1 + testObjs2;
            dualListString = dualList.ToString();

            Assert.AreEqual(dualListString, "CustomListTest.ExampleClassTest: 10, CustomListTest.ExampleClassTest: 20, CustomListTest.ExampleClassTest: 30, CustomListTest.ExampleClassTest: 40, CustomListTest.ExampleClassTest: 50");
        }

        [TestMethod]
        public void Zip_TwoIntLists_ZipListsTogether()
        {
            string zipListString;

            CustomList<int> testInts1 = new CustomList<int>();
            CustomList<int> testInts2 = new CustomList<int>();

            testInts1.Add(2);
            testInts1.Add(6);
            testInts1.Add(4);

            testInts2.Add(9);
            testInts2.Add(3);
            testInts2.Add(5);

            testInts1.Zip(testInts2);

            zipListString = testInts1.ToString();
            Assert.AreEqual(zipListString, "2, 9, 6, 3, 4, 5");
        }
    }
}
