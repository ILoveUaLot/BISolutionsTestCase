using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BISolutionsTests
{
    public class LinkedListTests
    {
        [Fact]
        public void Add_ShouldAddValuesCorrectly()
        {
            LinkedList.LinkedList<int> list = new LinkedList.LinkedList<int>();

            list.Add(5);
            list.Add(10);
            list.Add(15);

            Assert.Equal(new int[] { 5, 10, 15 }, list.GetValues().ToArray());
        }
    }
}
