
namespace Abstract_Factory_Pattern
{
    public class ToyotaEngine : IEngine
    {
        public void Build()
        {
            Console.WriteLine("Toyota Engine created");
        }
    }

    public class ToyotaTire : ITire
    {
        public void Build()
        {
            Console.WriteLine("Toyota Tire created");
        }
    }

    public class ToyotaFactory : ICarFactory
    {
        public IEngine CreateEngine()
        {
            return new ToyotaEngine();
        }

        public ITire CreateTire()
        {
            return new ToyotaTire();
        }
    }
}
