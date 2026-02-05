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
        public fp speed = fp._0_10;
        public fp distance = fp._3;
        public Transform lookAt;
        
        
        private void Update()
        {
            fp scaledTime = (fp)Time.time * speed;
            fp x = math.sin(scaledTime);
            fp y = 1.5f + math.sin(1.1234f * + scaledTime);
            fp z = math.sin(1.3453f * scaledTime);

            Vector3 dir = new Vector3(x, y, z).normalized;
            Vector3 pos = lookAt.position + distance * dir;

            transform.position = pos;
            transform.rotation = Quaternion.LookRotation(lookAt.position - pos);
        }
    }
}