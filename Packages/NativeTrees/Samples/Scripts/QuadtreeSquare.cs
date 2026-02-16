using System;
using NativeTrees;
using Unity.Mathematics.Fixed;
using UnityEngine;

namespace NativeTrees.Samples
{
    public class QuadtreeSquare : MonoBehaviour
    {
        [SerializeField] private SpriteRenderer spriteRenderer;
        
        public static readonly Vector2 Extents = new float2(fp._0_50, fp._0_50);

        public AABB2D Bounds
        {
            get
            {
                Vector2 pos = transform.position;
                return new AABB2D(pos - Extents, pos + Extents);
            }
        }

        public Color Color
        {
            get => spriteRenderer.color;
            set => spriteRenderer.color = value;
        }
    }
}