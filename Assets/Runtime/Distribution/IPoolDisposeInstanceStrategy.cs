namespace Fp.Pooling.Distribution
{
    public interface IPoolDisposeInstanceStrategy<in T> : IPoolStrategies
    {
        void PoolDisposeInstance(T instance);
    }
}