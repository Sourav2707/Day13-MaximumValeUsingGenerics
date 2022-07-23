using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaximumValue
{
    public class Find<T> where T : IComparable //class type generics
    {
        public T[] Sorting(T[] values)
        {
            Array.Sort(values);
            return values;
        }
        public void ToCompare(params T[] values) 
        {
            T[] compare = Sorting(values);
            Console.WriteLine(compare[^1]);
        }
    }
}
