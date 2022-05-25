using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using FileParserAdv;
using Contracts;

namespace ParallelForLoopExample
{
    internal class Program
    {
        public static FileParser parser = new FileParser();
        public static DateTime startingPoint = DateTime.Now;

        static void Main(string[] args)
        {
            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine($"Thread={Thread.CurrentThread.ManagedThreadId}");
                List<CustomerOrders> orders = parser.ReadFile($"C:\\Users\\mdgon\\source\\repos\\C# Training\\ThreadingExample\\Excell Books\\DataSet{i}.xlsx");
            }

            DateTime endpoint = DateTime.Now;
            TimeSpan timespan = endpoint - startingPoint;
            Console.WriteLine($"Time Elapsed for thread, {Thread.CurrentThread.ManagedThreadId}: {timespan.Milliseconds} ms");

            startingPoint = DateTime.Now;
            Parallel.For(1, 4, i =>
            {
                Console.WriteLine($"Thread={Thread.CurrentThread.ManagedThreadId}");
                List<CustomerOrders> orders = parser.ReadFile($"C:\\Users\\mdgon\\source\\repos\\C# Training\\ThreadingExample\\Excell Books\\DataSet{i}.xlsx");
                endpoint = DateTime.Now;
                timespan = endpoint - startingPoint;
                Console.WriteLine($"Time Elapsed for thread, {Thread.CurrentThread.ManagedThreadId}: {timespan.Milliseconds} ms");
            });



            Console.ReadKey();
        }
    }
}
