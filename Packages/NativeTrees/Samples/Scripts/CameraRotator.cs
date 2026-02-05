using Deterministic.FixedPoint;
using UnityEngine;
using Unity.Mathematics.Fixed;

namespace NativeTrees.Samples
{
    /// <summary>
    /// Just creates some cool camera movement
    /// </summary>
    public class CameraRotator : MonoBehaviour
    {
        public float speed = 0.1f;
        public float distance = 3;
        public Transform lookAt;
        
        
        private void Update()
        {
            float scaledTime = (float)Time.time * speed;
            float x = Mathf.Sin(scaledTime);
            float y = 1.5f + Mathf.Sin(1.1234f * + scaledTime);
            float z = Mathf.Sin(1.3453f * scaledTime);

            Vector3 dir = new Vector3(x, y, z).normalized;
            Vector3 pos = lookAt.position + distance * dir;

            transform.position = pos;
            transform.rotation = Quaternion.LookRotation(lookAt.position - pos);
        }
    }
}