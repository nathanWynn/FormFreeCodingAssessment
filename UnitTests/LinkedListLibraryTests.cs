using System;
using LinkedListLibrary;
using Xunit;

namespace UnitTests
{
    public class LinkedListLibraryTests
    {
        LinkedListLibrary.LinkedList<string> myStringLinkedList;
        LinkedListLibrary.LinkedList<int> myIntLinkedList;

        [Theory]
        [InlineData(new int[] { 1, 2, 3, 4, 5, 6, 7, 8 }, 4)]
        [InlineData(new int[] { 1, 2, 3, 4, 5 }, 1)]
        public void ValidIntListTest(int[]list, int expected)
        {
            myIntLinkedList = new LinkedListLibrary.LinkedList<int>(list);
            int actual = myIntLinkedList.GetFifthLastElement();
            Assert.Equal(actual, expected);
        }
        [Theory]
        [InlineData(new string[] { "a", "b", "c", "d", "e", "f", "g" }, "c")]
        [InlineData(new string[] { "a", "b", null, "d", "e", "f", "g" }, null)]
        [InlineData(new string[] { "a", "b", "c", "d", "e" }, "a")]
        public void ValidStringListTest(string[] list, string expected)
        {
            myStringLinkedList = new LinkedListLibrary.LinkedList<string>(list);
            string actual = myStringLinkedList.GetFifthLastElement();
            Assert.Equal(actual, expected);
        }
        [Fact]
        public void LongIntListTest()
        {
            int[] longList = new int[10000];
            for (int i = 0; i < 10000; i++)
            {
                longList[i] = i;
            }
            myIntLinkedList = new LinkedListLibrary.LinkedList<int>(longList);
            int expected = 9995;
            int actual = myIntLinkedList.GetFifthLastElement();
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void LongStringListTest()
        {
            string[] longList = new string[10000];
            for (int i = 0; i < 10000; i++)
            {
                longList[i] = i.ToString();
            }
            myStringLinkedList = new LinkedListLibrary.LinkedList<string>(longList);
            string expected = "9995";
            string actual = myStringLinkedList.GetFifthLastElement();
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void InvalidStringListTest()
        {
            myStringLinkedList = new LinkedListLibrary.LinkedList<string>(new string[] { "a", "b", "c" });
            Assert.Throws<InvalidOperationException>(() => myStringLinkedList.GetFifthLastElement());
        }
        [Fact]
        public void InvalidIntListTest()
        {
            myIntLinkedList = new LinkedListLibrary.LinkedList<int>(new int[] { 1, 2, 3 });
            Assert.Throws<InvalidOperationException>(() => myIntLinkedList.GetFifthLastElement());
        }
        [Fact]
        public void EmptyListTest()
        {
            myIntLinkedList = new LinkedListLibrary.LinkedList<int>(new int[] { });
            Assert.Throws<InvalidOperationException>(() => myIntLinkedList.GetFifthLastElement());
        }
        [Fact]
        public void nullListTest()
        {
            Assert.Throws<NullReferenceException>(() => 
            myStringLinkedList = new LinkedListLibrary.LinkedList<string>(null));
        }
    }
}
