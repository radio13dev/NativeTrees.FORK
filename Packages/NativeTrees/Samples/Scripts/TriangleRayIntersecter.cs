using System;
using Deterministic.FixedPoint;
using NativeTrees;
using Unity.Mathematics.Fixed;
using UnityEngine;

namespace NativeTrees.Samples
{
    public struct TriangleRayIntersecter : IOctreeRayIntersecter<Triangle>
    {
        public bool IntersectRay(in PrecomputedRay ray, Triangle triangle, AABB objBounds, out fp distance)
        {
            if (!objBounds.IntersectsRay(ray))
            {
                distance = fp.usable_max;
                return false;
            }

            return triangle.IntersectsRay(ray.origin, ray.dir, out distance);
        }
    }
}