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
            Assert.AreEqual(list, list1);
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
            CustomList<TestObject> list = new CustomList<TestObject>();
            list.Add(new TestObject());
            Assert.AreEqual(new TestObject(), list[0]);
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
            CustomList<TestObject> list = new CustomList<TestObject>();
            list.Add(new TestObject());
            list.Add(new TestObject());
            list.Add(new TestObject());
            list.Add(new TestObject());
            Assert.AreEqual(new TestObject(), list[0]);
        }
        //adding value to check for default capacity
        [TestMethod]
        public void add_valueInt_checkForDefault()
        {
            CustomList<int> list = new CustomList<int>();
            list.Add(1);
            Assert.AreEqual(4, list.capacity);
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
            Assert.Equals(0.0D, list[0]);
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
            list.Remove(0);
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
            list.Remove("foo");
            Assert.AreEqual("bye", list[0]);
        }

        [TestMethod]

        public void remove_valueBool_checkPastValue()
        {
            CustomList<bool> list = new CustomList<bool>();
            list.Add(true);
            list.Add(false);
            list.Remove(true);
            Assert.AreEqual(true, list[0]);
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
            Assert.AreEqual(first, list[0]);

        }
        //removing value checking count of elements
        [TestMethod]

        public void remove_valueInt_checkList()
        {
            CustomList<int> list = new CustomList<int>();
            list.Add(1);
            list.Add(2);
            list.Remove(1);
            Assert.AreEqual(1, list.count);
        }
        //converting list to string
        [TestMethod]

        public void convert_listint_ToString()
        {
            CustomList<int> list = new CustomList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            string expected = list.ToString();
            Assert.AreEqual("123", expected);
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
            Assert.AreEqual(list2, list3);
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
            list2.Add(0);
            list2.Add(1);
            CustomList<int> list3 = list - list1;
            Assert.AreEqual(list2, list3);

        }
        //zipper
        [TestMethod]

        public void zip_list1list2_list3()
        {
            CustomList<int> list = new CustomList<int>();
            CustomList<int> list1 = new CustomList<int>();
            CustomList<int> list2 = new CustomList<int>();
            list.Add(1);
            list.Add(3);
            list.Add(5);
            list1.Add(2);
            list1.Add(4);
            list2.Add(1);
            list2.Add(2);
            list2.Add(3);
            list2.Add(4);
            list2.Add(5);
            list.zipper(list1);
            Assert.AreEqual(list2, list);

        }
    }
}
