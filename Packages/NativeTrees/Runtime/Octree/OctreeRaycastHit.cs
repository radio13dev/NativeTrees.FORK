using Unity.Mathematics.Fixed;

namespace NativeTrees
{
    public struct OctreeRaycastHit<T>
    {
        public float3 point;
        public T obj;
    }
}