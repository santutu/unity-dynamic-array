using Santutu.Core.LengthArray.Runtime;
using UnityEngine;

namespace Santutu.Core.LengthArray.Samples
{
    public class Sample : MonoBehaviour
    {
        //don't worry about the array size. It's a trivial and unnecessary.
        [SerializeField] public LengthArray<RaycastHit> lengthArray = new();

        private void Start()
        {
            var ray = new Ray(transform.position, transform.forward);

            //you can loop using foreach.
            foreach (var hit in LengthPhysics.SphereCastNonAlloc(ray, 1, 1000, lengthArray))
            {
                Debug.Log(hit.collider.name);
            }

            //the original style.
            for (var i = 0; i < LengthPhysics.SphereCastNonAlloc(ray, 1, 1000, lengthArray).Length; i++)
            {
                Debug.Log(lengthArray[i].collider.name);
            }

            Debug.Log(lengthArray.Length); //number of detected collisions
            Debug.Log(lengthArray.TotalLength); //actual array size
            Debug.Log(lengthArray[0]); //accessing array elements
        }
    }
}