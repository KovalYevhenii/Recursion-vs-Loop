using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;

namespace LoopsAndRecursion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();
            int fibo5 = FibonacciReqursive(5);
            stopwatch.Stop();
            Console.WriteLine($"Fibonacci[5] = {fibo5}; ticks: {stopwatch.ElapsedTicks} ms {stopwatch.ElapsedMilliseconds}");

            stopwatch.Start();
            int fibo10 = FibonacciReqursive(10);
            stopwatch.Stop();
            Console.WriteLine($"Fibonacci[10] = {fibo10}; ticks: {stopwatch.ElapsedTicks} ms {stopwatch.ElapsedMilliseconds}");

            stopwatch.Start();
            int fibo20 = FibonacciReqursive(20);
            stopwatch.Stop();
            Console.WriteLine($"Fibonacci[20] = {fibo20}; ticks: {stopwatch.ElapsedTicks} ms {stopwatch.ElapsedMilliseconds}");

            stopwatch.Start();
            int fiboLoop5 = FiboLoop(5);
            stopwatch.Stop();
            Console.WriteLine($"Fibonacci[5]{fiboLoop5}; ticks: {stopwatch.ElapsedTicks} ms {stopwatch.ElapsedMilliseconds}");

            stopwatch.Start();
            int fiboLoop10 = FiboLoop(10);
            stopwatch.Stop();
            Console.WriteLine($"Fibonacci[10]{fiboLoop10}; ticks: {stopwatch.ElapsedTicks} ms {stopwatch.ElapsedMilliseconds}");

            stopwatch.Start();
            int fiboLoop20 = FiboLoop(20);
            stopwatch.Stop();
            Console.WriteLine($"Fibonacci[20]{fiboLoop20}; ticks: {stopwatch.ElapsedTicks} ms {stopwatch.ElapsedMilliseconds}");
        }
        public static int FibonacciReqursive(int n)
        {
            
            if (n <= 1)
                return n;
            else
            {
                return FibonacciReqursive(n - 1) + FibonacciReqursive(n - 2);
            }
           
        }
        public static int FiboLoop(int n)
        {
            int next;
            int first = 0;
            int second = 1;
            
            for (int i = 0; i < n; i++)
            {
                next = first + second;
                first = second;
                second = next;
            }
            return first;
        }
    }
}