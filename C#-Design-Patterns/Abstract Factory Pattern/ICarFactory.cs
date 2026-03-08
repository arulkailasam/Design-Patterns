
namespace Abstract_Factory_Pattern
{
    public interface IEngine
    {
        void Build();
    }

    public interface ITire
    {
        void Build();
    }

    public interface ICarFactory
    {
        IEngine CreateEngine();
        ITire CreateTire();
    }
}
