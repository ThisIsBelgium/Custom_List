using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Custom_List;

namespace CustomListTests
{
    [TestClass]
    public class CustomListUnitTests
    {

        [TestMethod]
        public void Get_list_returnlist()
        {
            CustomList<int> list = new CustomList<int>();
            CustomList<int> list1 = new CustomList<int>();
            Assert.AreEqual(list, list);
        }
        //adding value checking at the index of the add
        [TestMethod]
        public void add_valueInt_checkIndex()
        {
            CustomList<int> list = new CustomList<int>();
            int item = 1;
            list.Add(item);
            Assert.AreEqual(item, list[0]);
        }

        [TestMethod]
        public void add_valueDouble_checkIndex()
        {
            CustomList<double> list = new CustomList<double>();
            double item = .5;
            list.Add(item);
            Assert.AreEqual(item, list[0]);
        }

        public void add_valueString_checkIndex()
        {
            CustomList<string> list = new CustomList<string>();
            string item = "hi";
            list.Add(item);
            Assert.AreEqual(item, list[0]);

        }

        [TestMethod]

        public void add_valueBool_checkIndex()
        {
            CustomList<bool> list = new CustomList<bool>();
            bool item = true;
            list.Add(item);
            Assert.AreEqual(item, list[0]);

        }

        [TestMethod]

        public void add_valueObject_checkIndex()
        {
            TestObject test = new TestObject();
            CustomList<TestObject> list = new CustomList<TestObject>();
            list.Add(test);
            Assert.AreEqual(test.test, list[0].test);
        }

        //adding values checking the prior indexes
        [TestMethod]
        public void add_valueInt_checkPastIndex()
        {
            CustomList<int> list = new CustomList<int>();
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.Add(6);
            Assert.AreEqual(4, list[1]);

        }
        [TestMethod]

        public void add_valueDouble_checkPastIndex()
        {
            CustomList<double> list = new CustomList<double>();
            list.Add(.5);
            list.Add(.7);
            list.Add(.9);
            Assert.AreEqual(.9, list[2]);
        }

        [TestMethod]

        public void add_valueString_checkPastIndex()
        {
            CustomList<string> list = new CustomList<string>();
            list.Add("Hi");
            list.Add("Foo");
            list.Add("Bar");
            list.Add("Fizz");
            Assert.AreEqual("Foo", list[1]);
        }

        [TestMethod]

        public void add_valueBool_checkPastIndex()
        {
            CustomList<bool> list = new CustomList<bool>();
            list.Add(true);
            list.Add(false);
            list.Add(true);
            list.Add(false);
            Assert.AreEqual(false, list[1]);
        }

        [TestMethod]

        public void add_valueObject_checkPastIndex()
        {
            TestObject test = new TestObject();
            CustomList<TestObject> list = new CustomList<TestObject>();
            list.Add(test);
            list.Add(test);
            list.Add(test);
            list.Add(test);
            Assert.AreEqual(test.test, list[0].test);
        }
        //adding value to check for default capacity
        [TestMethod]
        public void add_valueInt_checkForDefault()
        {
            CustomList<int> list = new CustomList<int>();
            list.Add(1);
            Assert.AreEqual(4, list.Capacity);
        }
        //removing value checking for default of index
        [TestMethod]

        public void remove_valueInt_checkRemove()
        {
            CustomList<int> list = new CustomList<int>();
            list.Add(1);
            list.Remove(1);
            Assert.AreEqual(0, list[0]);
        }

        [TestMethod]
        public void remove_valueDouble_checkRemove()
        {
            CustomList<double> list = new CustomList<double>();
            list.Add(.5);
            list.Remove(.5);
            Assert.AreEqual(default(double), list[0]);
        }

        [TestMethod]

        public void remove_valueString_checkRemove()
        {
            CustomList<string> list = new CustomList<string>();
            list.Add("hi");
            list.Remove("hi");
            Assert.AreEqual(null, list[0]);
        }

        [TestMethod]

        public void remove_valueBool_checkRemove()
        {
            CustomList<bool> list = new CustomList<bool>();
            list.Add(true);
            list.Remove(true);
            Assert.AreEqual(false, list[0]);
        }

        [TestMethod]

        public void remove_ValueObject_checkRemove()
        {
            TestObject one = new TestObject();
            CustomList<TestObject> list = new CustomList<TestObject>();
            list.Add(one);
            list.Remove(one);
            Assert.AreEqual(null, list[0]);

        }
        //removing  value checking past indexes
        [TestMethod]

        public void remove_valueInt_checkPastValue()
        {
            CustomList<int> list = new CustomList<int>();
            list.Add(1);
            list.Add(4);
            list.Add(4);
            list.Remove(1);
            Assert.AreEqual(4, list[0]);
        }
        [TestMethod]
        public void remove_valueDouble_checkPastValue()
        {
            CustomList<double> list = new CustomList<double>();
            list.Add(.5);
            list.Add(1.6);
            list.Add(.15);
            list.Remove(.5);
            Assert.AreEqual(1.6, list[0]);
        }

        [TestMethod]

        public void remove_valueString_checkPastValue()
        {
            CustomList<string> list = new CustomList<string>();
            list.Add("hi");
            list.Add("bye");
            list.Add("foo");
            list.Remove("hi");
            Assert.AreEqual("bye", list[0]);
        }

        [TestMethod]

        public void remove_valueBool_checkPastValue()
        {
            CustomList<bool> list = new CustomList<bool>();
            list.Add(true);
            list.Add(false);
            list.Remove(true);
            Assert.AreEqual(false, list[0]);
        }

        [TestMethod]

        public void remove_valueObject_checkPastValue()
        {
            TestObject first = new TestObject();
            CustomList<TestObject> list = new CustomList<TestObject>();
            list.Add(first);
            list.Add(first);
            list.Add(first);
            list.Add(first);
            list.Remove(first);
            Assert.AreEqual(first.test, list[0].test);

        }
        //removing value checking count of elements
        [TestMethod]

        public void remove_valueInt_checkList()
        {
            CustomList<int> list = new CustomList<int>();
            list.Add(1);
            list.Add(2);
            list.Remove(1);
            Assert.AreEqual(1, list.Count);
        }
        //converting list to string
        [TestMethod]

        public void convert_listint_ToString()
        {
            CustomList<int> list = new CustomList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            string acutual = list.ToString();
            Assert.AreEqual("1 2 3 ", acutual);
        }
        [TestMethod]

        public void convert_listString_ToString()
        {
            CustomList<string> list = new CustomList<string>();
            list.Add("Hi");
            list.Add("Bye");
            list.Add("Hello");
            string acutual = list.ToString();
            Assert.AreEqual("Hi Bye Hello ", acutual);
        }

        [TestMethod]
        public void convert_listDouble_ToString()
        {
            CustomList<double> list = new CustomList<double>();
            list.Add(.5);
            list.Add(1.8);
            list.Add(3.6);
            string acutual = list.ToString();
            Assert.AreEqual("0.5 1.8 3.6 ", acutual);
        }

        [TestMethod]
        public void convert_listBool_ToString()
        {
            CustomList<bool> list = new CustomList<bool>();
            list.Add(false);
            list.Add(true);
            list.Add(true);
            string acutual = list.ToString();
            Assert.AreEqual("False True True ", acutual);
        }

        [TestMethod]
        public void convert_listObject_ToString()
        {
            TestObject first = new TestObject();
            CustomList<TestObject> list = new CustomList<TestObject>();
            list.Add(first);
            list.Add(first);
            list.Add(first);
            string acutual = list.ToString();
            Assert.AreEqual("Custom_List.TestObject Custom_List.TestObject Custom_List.TestObject ", acutual);
        }

        //adding lists
        [TestMethod]

        public void concat_list1List2_List3()
        {
            CustomList<int> list = new CustomList<int>();
            CustomList<int> list1 = new CustomList<int>();
            CustomList<int> list2 = new CustomList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list1.Add(4);
            list1.Add(5);
            list1.Add(6);
            list2.Add(1);
            list2.Add(2);
            list2.Add(3);
            list2.Add(4);
            list2.Add(5);
            list2.Add(6);
            CustomList<int> list3 = list + list1;
            Assert.AreEqual(list2.Count, list3.Count);
        }
        //subtracting lists
        [TestMethod]

        public void subtract_list1list2_list3()
        {
            CustomList<int> list = new CustomList<int>();
            CustomList<int> list1 = new CustomList<int>();
            CustomList<int> list2 = new CustomList<int>();
            list.Add(1);
            list.Add(2);
            list1.Add(1);
            list1.Add(1);
            list2.Add(2);
            CustomList<int> list3 = list - list1;
            Assert.AreEqual(list2[0], list3[0]);

        }
        //zipper
        [TestMethod]

        public void zip_list1list2Int_list3()
        {
            CustomList<int> list = new CustomList<int>();
            CustomList<int> list1 = new CustomList<int>();
            CustomList<int> list2 = new CustomList<int>();
            list.Add(1);
            list.Add(3);
            list.Add(5);
            list1.Add(2);
            list1.Add(4);
            list1.Add(6);
            list2.Add(1);
            list2.Add(2);
            list2.Add(3);
            list2.Add(4);
            list2.Add(5);
            list2.Add(6);
            CustomList<int> list3 = list.Zipper(list1);
            Assert.AreEqual(list2[1], list3[1]);

        }

        [TestMethod]

        public void zip_list1list2String_list3()
        {
            CustomList<string> list = new CustomList<string>();
            CustomList<string> list1 = new CustomList<string>();
            CustomList<string> list2 = new CustomList<string>();
            list.Add("Hi");
            list.Add("Foo");
            list.Add("Bar");
            list1.Add("Hello");
            list1.Add("Bye");
            list1.Add("Cya");
            list2.Add("Hi");
            list2.Add("Hello");
            list2.Add("Foo");
            list2.Add("Bye");
            list2.Add("Bar");
            list2.Add("Cya");
            CustomList<string> list3 = list.Zipper(list1);
            Assert.AreEqual(list2[1], list3[1]);

        }

        [TestMethod]
        public void zip_list1list2Bool_list3()
        {
            CustomList<bool> list = new CustomList<bool>();
            CustomList<bool> list1 = new CustomList<bool>();
            CustomList<bool> list2 = new CustomList<bool>();
            list.Add(true);
            list.Add(false);
            list.Add(true);
            list1.Add(true);
            list1.Add(false);
            list1.Add(true);
            list2.Add(true);
            list2.Add(true);
            list2.Add(false);
            list2.Add(false);
            list2.Add(true);
            list2.Add(true);
            CustomList<bool> list3 = list.Zipper(list1);
            Assert.AreEqual(list2[1], list3[1]);

        }

        [TestMethod]

        public void zip_list1list2Double_list3()
        {
            CustomList<double> list = new CustomList<double>();
            CustomList<double> list1 = new CustomList<double>();
            CustomList<double> list2 = new CustomList<double>();
            list.Add(.5);
            list.Add(1.5);
            list.Add(3.6);
            list1.Add(1.8);
            list1.Add(39.8);
            list1.Add(3.15);
            list2.Add(.5);
            list2.Add(1.8);
            list2.Add(1.5);
            list2.Add(39.8);
            list2.Add(3.6);
            list2.Add(3.15);
            CustomList<double> list3 = list.Zipper(list1);
            Assert.AreEqual(list2[1], list3[1]);

        }
    }
}
