using System;

namespace VectorMath
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fun with vectors");

            Vector3 one = new Vector3(3, 4, 5);
            Vector3 two = new Vector3(4, 8, 0);

            Console.WriteLine($"Static method Add: {Vector3.Add(one, two)}");

            Console.WriteLine($"Object method Add: {one.Add(two)}");

            Console.WriteLine($"Operator: {one + two}");

            Console.WriteLine($"Subtraction: {one - two}");

            Console.WriteLine($"Scalar multiplication: {2 * one}");

            Console.WriteLine($"Scalar multiplication: {two * 5}");

            Console.WriteLine($"Should not be equal: {one == two}");

            Console.WriteLine($"Should be equal: {one == new Vector3(3, 4, 5)}");
            Console.WriteLine($"Preincrement: {++one}");
            Console.WriteLine($"Postincrement {one++}");

            Console.WriteLine($"Magnitude: {~one}");


        }
    }
}
