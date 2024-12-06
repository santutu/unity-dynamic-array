using Santutu.Core.LengthArray.Runtime;
using UnityEngine;

namespace Santutu.Core.LengthArray.Samples
{
    public class Sample : MonoBehaviour
    {
        [SerializeField] public LengthArray<RaycastHit> lengthArray = new();

        private void Start()
        {
            var ray = new Ray(transform.position, transform.forward);
            
            foreach (var hit in LengthPhysics.SphereCastNonAlloc(ray, 1, 1000, lengthArray))
            {
                Debug.Log(hit.collider.name);
            }
        }
    }
}