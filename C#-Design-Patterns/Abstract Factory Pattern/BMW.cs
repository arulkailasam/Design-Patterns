
namespace Abstract_Factory_Pattern
{
    public class BmwEngine : IEngine
    {
        public void Build()
        {
            Console.WriteLine("BMW Engine created");
        }
    }

    public class BmwTire : ITire
    {
        public void Build()
        {
            Console.WriteLine("BMW Tire created");
        }
    }

    public class BmwFactory : ICarFactory
    {
        public IEngine CreateEngine()
        {
            return new BmwEngine();
        }

        public ITire CreateTire()
        {
            return new BmwTire();
        }
    }
}
