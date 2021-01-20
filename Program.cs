using System;

namespace MoreArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new[] { 3, 7, 9, 2, 14, 6 };

            // Original Array
            foreach (var n in numbers)
                Console.WriteLine(n);

            // Length
            Console.WriteLine("\nLength: " + numbers.Length);

            // IndexOf()
            var index = Array.IndexOf(numbers, 9);
            Console.WriteLine("\nIndex of 9:" + index);

            // Clear()
            Array.Clear(numbers, 0,2);

            Console.WriteLine("\nEffect of Clear()");
            foreach(var n in numbers)
                Console.WriteLine(n);
            
            // Copy()
            int[] another = new int[3];
            Array.Copy(numbers, another, 3);
            
            Console.WriteLine("\nEffect of Copy()");
            foreach (var n in another)
                Console.WriteLine(n);

            // Sort()
            Array.Sort(numbers);
            Console.WriteLine("\nEffect of Sort()");
            foreach (var n in numbers)
                Console.WriteLine(n);

            // Reverse()
            Array.Reverse(numbers);
            Console.WriteLine("\nEffect of Reverse()");
            foreach (var n in numbers)
                Console.WriteLine(n);
        }
    }
}
