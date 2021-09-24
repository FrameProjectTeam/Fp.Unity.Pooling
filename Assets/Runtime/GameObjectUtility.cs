using UnityEngine;

namespace Fp.Pooling
{
    public static class GameObjectUtility
    {
        public static void SafeDestroy(this Object obj)
        {
#if UNITY_EDITOR
            if (!Application.isPlaying)
            {
                Object.DestroyImmediate(obj);
                return;
            }
#endif
            Object.Destroy(obj);
        }
    }
}