using System;
using Xunit;
using bubblesort;

namespace TestProject2
{
    public class Bubblesortstringtest
    {
        [Fact]
        public void BubbleSortAscendingOrder()
        {
            List<string> list = new List<string> { "banana", "apple", "orange" };
            int length = list.Count;

            bubblesort.Program.BubbleSortAscending(list, length);

            Assert.Equal(new List<string> { "apple", "banana", "orange" }, list);
        }

        [Fact]
        public void BubbleSortAscendingFails()
        {
            List<string> list = new List<string> { "apple", "banana", "orange" };
            int length = list.Count;

            bubblesort.Program.BubbleSortAscending(list, length);

            Assert.Equal(new List<string> { "apple", "orange", "banana"}, list);
        }

        [Fact]
        public void BubbleSortDescendingOrder()
        {
            List<string> list = new List<string> { "banana", "apple", "orange" };
            int length = list.Count;

            bubblesort.Program.BubbleSortDescending(list, length);

            Assert.Equal(new List<string> { "orange", "banana", "apple" }, list);
        }

        [Fact]
        public void BubbleSortDescendingFails()
        {
            List<string> list = new List<string> { "apple", "banana", "orange" };
            int length = list.Count;

            bubblesort.Program.BubbleSortDescending(list, length);

            Assert.Equal(new List<string> { "orange", "apple" , "banana" }, list);
        }
    }
}
