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

            Assert.AreEqual(objList[0].ExampleInt, 1);
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

            Assert.AreNotEqual(objList[2].ExampleInt, 3);
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

            zipListString = testInts1.Zip(testInts2).ToString();
            Assert.AreEqual(zipListString, "2, 9, 6, 3, 4, 5");
        }

        [TestMethod]
        public void Zip_TwoStringLists_ZipListsTogether()
        {
            string zipListString;

            CustomList<string> testStrings1 = new CustomList<string>();
            CustomList<string> testStrings2 = new CustomList<string>();

            testStrings1.Add("H");
            testStrings1.Add("l");
            testStrings1.Add("o");

            testStrings2.Add("e");
            testStrings2.Add("l");

            zipListString = testStrings1.Zip(testStrings2).ToString();
            Assert.AreEqual(zipListString, "H, e, l, l, o");
        }

        [TestMethod]
        public void Zip_TwoObjLists_ZipListsTogether()
        {
            string zipListString;

            ExampleClassTest exampleObj1 = new ExampleClassTest(10);
            ExampleClassTest exampleObj2 = new ExampleClassTest(20);

            ExampleClassTest exampleObj3 = new ExampleClassTest(30);
            ExampleClassTest exampleObj4 = new ExampleClassTest(40);
            ExampleClassTest exampleObj5 = new ExampleClassTest(50);
            ExampleClassTest exampleObj6 = new ExampleClassTest(60);

            CustomList<ExampleClassTest> testObjs1 = new CustomList<ExampleClassTest>();
            CustomList<ExampleClassTest> testObjs2 = new CustomList<ExampleClassTest>();

            testObjs1.Add(exampleObj1);
            testObjs1.Add(exampleObj2);

            testObjs2.Add(exampleObj3);
            testObjs2.Add(exampleObj4);
            testObjs2.Add(exampleObj5);
            testObjs2.Add(exampleObj6);

            zipListString = testObjs1.Zip(testObjs2).ToString();
            Assert.AreEqual(zipListString, "CustomListTest.ExampleClassTest: 10, CustomListTest.ExampleClassTest: 30, CustomListTest.ExampleClassTest: 20, CustomListTest.ExampleClassTest: 40, CustomListTest.ExampleClassTest: 50, CustomListTest.ExampleClassTest: 60");
        }

        [TestMethod]
        public void Enumaration_IntList_RunForEachLoop()
        {
            int total = 0;

            CustomList<int> testInts1 = new CustomList<int>();

            testInts1.Add(1);
            testInts1.Add(2);
            testInts1.Add(3);

            foreach (int number in testInts1)
            {
                total += number;
            }

            Assert.AreEqual(total, 6);
        }

        [TestMethod]
        public void Enumaration_StringList_RunForEachLoop()
        {
            string loopString = "";

            CustomList<string> testStrings1 = new CustomList<string>();

            testStrings1.Add("H");
            testStrings1.Add("e");
            testStrings1.Add("y");

            foreach (string letter in testStrings1)
            {
                loopString += letter;
            }

            Assert.AreEqual(loopString, "Hey");
        }

        [TestMethod]
        public void Enumaration_ObjectList_RunForEachLoop()
        {
            int total = 0;

            ExampleClassTest exampleObj1 = new ExampleClassTest(15);
            ExampleClassTest exampleObj2 = new ExampleClassTest(30);
            ExampleClassTest exampleObj3 = new ExampleClassTest(45);

            CustomList<ExampleClassTest> testObjs1 = new CustomList<ExampleClassTest>();

            testObjs1.Add(exampleObj1);
            testObjs1.Add(exampleObj2);
            testObjs1.Add(exampleObj3);

            foreach (ExampleClassTest obj in testObjs1)
            {
                total += obj.ExampleInt;
            }

            Assert.AreEqual(total, 90);
        }

        [TestMethod]
        public void OverloadMinus_TwoIntLists_RemoveList2ContentAfterPlus()
        {
            string dualListString;
            CustomList<int> dualList;

            CustomList<int> testInts1 = new CustomList<int>();
            CustomList<int> testInts2 = new CustomList<int>();

            testInts1.Add(1);
            testInts1.Add(2);
            testInts1.Add(3);
            testInts1.Add(4);

            testInts2.Add(5);
            testInts2.Add(6);
            testInts2.Add(7);

            testInts1 += testInts2;

            dualList = testInts1 - testInts2;

            dualListString = dualList.ToString();

            Assert.AreEqual(dualListString, "1, 2, 3, 4");
        }

        [TestMethod]
        public void OverloadMinus_TwoIntLists_RemoveList2ContentAfterZip()
        {
            string dualListString;
            CustomList<int> dualList;

            CustomList<int> testInts1 = new CustomList<int>();
            CustomList<int> testInts2 = new CustomList<int>();

            testInts1.Add(1);
            testInts1.Add(2);
            testInts1.Add(3);
            testInts1.Add(4);

            testInts2.Add(5);
            testInts2.Add(6);
            testInts2.Add(7);

            testInts1 = testInts1.Zip(testInts2);

            dualList = testInts1 - testInts2;

            dualListString = dualList.ToString();

            Assert.AreEqual(dualListString, "1, 2, 3, 4");
        }

        [TestMethod]
        public void OverloadMinus_TwoStringLists_RemoveList2ContentAfterPlus()
        {
            string dualListString;
            CustomList<string> dualList;

            CustomList<string> testChars1 = new CustomList<string>();
            CustomList<string> testChars2 = new CustomList<string>();

            testChars1.Add("a");
            testChars1.Add("b");
            testChars1.Add("c");
            testChars1.Add("d");

            testChars2.Add("e");
            testChars2.Add("f");
            testChars2.Add("g");

            testChars1 += testChars2;

            dualList = testChars1 - testChars2;

            dualListString = dualList.ToString();

            Assert.AreEqual(dualListString, "a, b, c, d");
        }

        [TestMethod]
        public void OverloadMinus_TwoStringLists_RemoveList2ContentAfterZip()
        {
            string dualListString;
            CustomList<string> dualList;

            CustomList<string> testChars1 = new CustomList<string>();
            CustomList<string> testChars2 = new CustomList<string>();

            testChars1.Add("a");
            testChars1.Add("b");
            testChars1.Add("c");
            testChars1.Add("d");

            testChars2.Add("e");
            testChars2.Add("f");
            testChars2.Add("g");

            testChars1 = testChars1.Zip(testChars2);

            dualList = testChars1 - testChars2;

            dualListString = dualList.ToString();

            Assert.AreEqual(dualListString, "a, b, c, d");
        }

        [TestMethod]
        public void OverloadMinus_TwoObjLists_RemoveList2ContentAfterPlus()
        {
            string objListString;

            ExampleClassTest exampleObj1 = new ExampleClassTest(10);
            ExampleClassTest exampleObj2 = new ExampleClassTest(20);

            ExampleClassTest exampleObj3 = new ExampleClassTest(30);
            ExampleClassTest exampleObj4 = new ExampleClassTest(40);
            ExampleClassTest exampleObj5 = new ExampleClassTest(50);

            CustomList<ExampleClassTest> testObjs1 = new CustomList<ExampleClassTest>();
            CustomList<ExampleClassTest> testObjs2 = new CustomList<ExampleClassTest>();

            testObjs1.Add(exampleObj1);
            testObjs1.Add(exampleObj2);

            testObjs2.Add(exampleObj3);
            testObjs2.Add(exampleObj4);
            testObjs2.Add(exampleObj5);

            testObjs1 += testObjs2;
            testObjs1 -= testObjs2;

            objListString = (testObjs1).ToString();
            Assert.AreEqual(objListString, "CustomListTest.ExampleClassTest: 10, CustomListTest.ExampleClassTest: 20");

            
        }

        [TestMethod]
        public void OverloadMinus_TwoObjLists_RemoveList2ContentAfterZip()
        {
            string objListString;

            ExampleClassTest exampleObj1 = new ExampleClassTest(10);
            ExampleClassTest exampleObj2 = new ExampleClassTest(20);

            ExampleClassTest exampleObj3 = new ExampleClassTest(30);
            ExampleClassTest exampleObj4 = new ExampleClassTest(40);
            ExampleClassTest exampleObj5 = new ExampleClassTest(50);

            CustomList<ExampleClassTest> testObjs1 = new CustomList<ExampleClassTest>();
            CustomList<ExampleClassTest> testObjs2 = new CustomList<ExampleClassTest>();

            testObjs1.Add(exampleObj1);
            testObjs1.Add(exampleObj2);

            testObjs2.Add(exampleObj3);
            testObjs2.Add(exampleObj4);
            testObjs2.Add(exampleObj5);

            testObjs1 = testObjs1.Zip(testObjs2);
            testObjs1 -= testObjs2;

            objListString = (testObjs1).ToString();
            Assert.AreEqual(objListString, "CustomListTest.ExampleClassTest: 10, CustomListTest.ExampleClassTest: 20");
        }

        //Limitation Testing
        [TestMethod]
        public void Add_1ThousandEntries_ListCountIs1Thousand()
        {
            CustomList<int> testInts1 = new CustomList<int>();

            for (int i = 0; i < 1000; i++)
            {
                testInts1.Add(i);
            }

            Assert.AreEqual(testInts1.Count, 1000);
        }

        [TestMethod]
        public void Remove_Ninehundred_ListCountIs1Hundred()
        {
            CustomList<int> testInts1 = new CustomList<int>();

            for (int i = 0; i < 1000; i++)
            {
                testInts1.Add(i);
            }
            for (int i = 0; i < 900; i++)
            {
                testInts1.Remove(i);
            }

            Assert.AreEqual(testInts1.Count, 100);
        }

        [TestMethod]
        public void Index_1ThousandEntries_AccessCertainEntry()
        {
            CustomList<int> testInts1 = new CustomList<int>();

            int certainEntry;

            for (int i = 0; i < 1000; i++)
            {
                testInts1.Add(i);
            }

            certainEntry = testInts1[432];

            Assert.AreEqual(certainEntry, 432);
        }

        [TestMethod]
        public void PlusOperator_1ThousandEntries_AccessCertainEntry()
        {
            CustomList<int> testInts1 = new CustomList<int>();
            CustomList<int> testInts2 = new CustomList<int>();

            int certainEntry;

            for (int i = 0; i < 1000; i++)
            {
                testInts1.Add(i);
            }

            testInts2.Add(1234);

            testInts1 += testInts2;

            certainEntry = testInts1[1000];

            Assert.AreEqual(certainEntry, 1234);
        }

        [TestMethod]
        public void MinusOperator_1ThousandEntries_CertainEntryMissing()
        {
            CustomList<int> testInts1 = new CustomList<int>();
            CustomList<int> testInts2 = new CustomList<int>();

            int certainEntry;

            for (int i = 0; i < 1000; i++)
            {
                testInts1.Add(i);
            }

            testInts2.Add(500);

            testInts1 -= testInts2;

            certainEntry = testInts1[500];

            Assert.AreNotEqual(certainEntry, 500);
        }
    }
}
