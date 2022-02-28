using System;
namespace DataStructure
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Stack<int> stack = new Stack<int>();
            //stack.Push(1581);
            //Console.WriteLine($"our stack contains {stack.Count} elements. The next item to process is {stack.Peek()}");
            //stack.Push(25);
            //Console.WriteLine($"our stack contains {stack.Count} elements. The next item to process is {stack.Peek()}");
            //stack.Push(34645);
            //Console.WriteLine($"our stack contains {stack.Count} elements. The next item to process is {stack.Peek()}");
            //stack.Pop();
            //Console.WriteLine($"our stack contains {stack.Count} elements. The next item to process is {stack.Peek()}");
            //stack.Pop();
            //Console.WriteLine($"our stack contains {stack.Count} elements. The next item to process is {stack.Peek()}");

            //Queue<int> stack = new Queue<int>();
            //stack.Enqueue(1581);
            //Console.WriteLine($"our stack contains {stack.Count} elements. The next item to process is {stack.Peek()}");
            //stack.Enqueue(25);
            //Console.WriteLine($"our stack contains {stack.Count} elements. The next item to process is {stack.Peek()}");
            //stack.Enqueue(34645);
            //Console.WriteLine($"our stack contains {stack.Count} elements. The next item to process is {stack.Peek()}");
            //stack.Dequeue();
            //Console.WriteLine($"our stack contains {stack.Count} elements. The next item to process is {stack.Peek()}");
            //stack.Dequeue();
            //Console.WriteLine($"our stack contains {stack.Count} elements. The next item to process is {stack.Peek()}");

            Queue<Order> orders = new Queue<Order>();
            orders.Enqueue(new Order() { Id = Guid.NewGuid(), Name = "Samsung S21 Ultra", Cost = 1600.00 });
            Console.WriteLine($"Orders contains {orders.Count} items. Next order to be processed is {orders.Peek().Name}");
            orders.Enqueue(new Order() { Id = Guid.NewGuid(), Name = "Macbook Pro 2023", Cost = 3500.00 });
            Console.WriteLine($"Orders contains {orders.Count} items. Next order to be processed is {orders.Peek().Name}");
            orders.Enqueue(new Order() { Id = Guid.NewGuid(), Name = "AKAI EWI USB", Cost = 250.00 });
            orders.Enqueue(new Order() { Id = Guid.NewGuid(), Name = "Fifine K658", Cost = 100.00 });
            Console.WriteLine($"Orders contains {orders.Count} items. Next order to be processed is {orders.Peek().Name}");
            //all orders made. Time to process.
            orders.Dequeue();
            Console.WriteLine($"Orders contains {orders.Count} items. Next order to be processed is {orders.Peek().Name}");
            orders.Dequeue();
            orders.Dequeue();
            Console.WriteLine($"Orders contains {orders.Count} items. Next order to be processed is {orders.Peek().Name}");
        }
    }
    class Order
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public double Cost { get; set; }
    }
}