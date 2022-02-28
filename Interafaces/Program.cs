
namespace Casting
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Michelin michelin = new Michelin()
            {
                Name = "MC-678-HJ",
                Description = "Lorem ipsum",
                ThreadDepth = 2.5
            };
            michelin.Fix("Vauxhaul Astra");
            GoodYear goodYear = new GoodYear()
            {
                Name = "GY-678-HJ",
                Description = "Lorem ipsum",
                ThreadDepth = 2.0
            };
            michelin.Fix("Toyota RAV4");
            BridgeStone bridgeStone = new BridgeStone()
            {
                Name = "BS-678-HJ",
                Description = "Lorem ipsum",
                ThreadDepth = 3.5
            };
            bridgeStone.Fix("Ford F250");
        }
    }
    // a standard of writing or implementing code inheriting from it.
    public interface ITyre
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double ThreadDepth { get; set; }
        public void Fix(string carName);
    }
    public class Michelin : ITyre
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double ThreadDepth { get; set; }

        public void Fix(string carName)
        {
            Console.WriteLine($"{carName} has now got the Michelin super tyre that runs great.");
        }
    }
    public class GoodYear : ITyre
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double ThreadDepth { get; set; }

        public void Fix(string carName)
        {
            Console.WriteLine($"{carName} has now got the GoodYear tyre.");
        }
    }
    public class BridgeStone : ITyre
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double ThreadDepth { get; set; }

        public void Fix(string carName)
        {
            Console.WriteLine($"{carName} now has the BridgeStone tyre.");
        }
    }
}