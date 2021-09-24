using System;

namespace Fp.Pooling
{
    public static class PoolExtensions
    {
        //TODO: Make it without open generic for T
        public static ActionInitPool<TArg, T> WithArg<TArg, T>(this ObjectPoolBase<T> pool, Action<T, TArg> initializer)
            where T : class
        {
            return new ActionInitPool<TArg, T>(pool, initializer);
        }
    }
}
