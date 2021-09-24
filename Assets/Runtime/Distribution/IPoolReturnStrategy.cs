namespace Fp.Pooling.Distribution
{
    public interface IPoolReturnStrategy<in T> : IPoolStrategies
    {
        void PoolBeforeReturn(T instance);
    }
}