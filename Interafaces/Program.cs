
namespace Casting
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Michelin michelin = new Michelin()
            //{
            //    Name = "MC-678-HJ",
            //    Description = "Lorem ipsum",
            //    ThreadDepth = 2.5
            //};
            //michelin.Fix("Vauxhaul Astra");
            //GoodYear goodYear = new GoodYear()
            //{
            //    Name = "GY-678-HJ",
            //    Description = "Lorem ipsum",
            //    ThreadDepth = 2.0
            //};
            //michelin.Fix("Toyota RAV4");
            //BridgeStone bridgeStone = new BridgeStone()
            //{
            //    Name = "BS-678-HJ",
            //    Description = "Lorem ipsum",
            //    ThreadDepth = 3.5
            //};
            //bridgeStone.Fix("Ford F250");
        }
    }
    //requirements
    public interface IReq
    {
        public bool isLicensed { get; set; }
        public bool isInsured { get; set; }
        public string license { get; set; }
    }
    public class Car : Vehicle, IReq
    {
        public string bodyType { get; set; }
    }
    public class Van: Vehicle, IReq
    {
    }
    public class Vehicle
    {
        public string make { get; set; }
        public int model { get; set; }
        public bool isLicensed { get; set; }
        public bool isInsured { get; set; }
        public bool isTaxed { get; set; }
        public string license { get; set; }
    }

    #region Ignore
    // a standard of writing or implementing code inheriting from it.
    public interface ITyre
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double ThreadDepth { get; set; }
        public void Fix(string carName);
    }
    public class BaseTyre
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double ThreadDepth { get; set; }
        public void Fix(string carName)
        {
            Console.WriteLine($"{carName} now has the {Name} type with description: {Description} and thread depth of {ThreadDepth}");
        }
    }
    public class Michelin : BaseTyre, ITyre
    {
        public new void Fix(string carName)
        {
            Console.WriteLine($"{carName} has now got the Michelin super tyre that runs great.");
        }
    }
    public class GoodYear : BaseTyre
    {
    }
    public class BridgeStone : BaseTyre
    {
        public new void Fix(string carName)
        {
            Console.WriteLine($"{carName} now has the BridgeStone tyre. Super strong");
        }
    }
    #endregion
}