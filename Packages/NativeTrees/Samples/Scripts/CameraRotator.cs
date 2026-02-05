using UnityEngine;

namespace NativeTrees.Samples
{
    /// <summary>
    /// Just creates some cool camera movement
    /// </summary>
    public class CameraRotator : MonoBehaviour
    {
        public fp speed = .1f;
        public fp distance = 3f;
        public Transform lookAt;
        
        
        private void Update()
        {
            fp scaledTime = Time.time * speed;
            fp x = Mathf.Sin(scaledTime);
            fp y = 1.5f + Mathf.Sin(1.1234f * + scaledTime);
            fp z = Mathf.Sin(1.3453f * scaledTime);

            Vector3 dir = new Vector3(x, y, z).normalized;
            Vector3 pos = lookAt.position + distance * dir;

            transform.position = pos;
            transform.rotation = Quaternion.LookRotation(lookAt.position - pos);
        }
    }
}