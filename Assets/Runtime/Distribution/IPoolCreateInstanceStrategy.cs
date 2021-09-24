namespace Fp.Pooling.Distribution
{
    public interface IPoolCreateInstanceStrategy<in T> : IPoolStrategies
    {
        void PoolCreateInstance(T instance);
    }
}