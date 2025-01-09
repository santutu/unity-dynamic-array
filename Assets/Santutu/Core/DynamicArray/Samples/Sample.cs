using Santutu.Core.DynamicArray.Runtime;
using UnityEngine;

namespace Santutu.Core.DynamicArray.Samples
{
    public class Sample : MonoBehaviour
    {
        //don't worry about the array size. It's a trivial and unnecessary.
        [SerializeField] public DynamicArray<RaycastHit> array = new();

        private void Start()
        {
            var ray = new Ray(transform.position, transform.forward);

            //you can loop using foreach.
            var results = DPhysics.SphereCastNonAlloc(ray, 1, array, 1000);

            foreach (var hit in results)
            {
                Debug.Log(hit.collider.name);
            }

            //the original style.
            var results2 = DPhysics.SphereCastNonAlloc(ray, 1, array, 1000);

            for (var i = 0; i < results2.Length; i++)
            {
                Debug.Log(array[i].collider.name);
            }

            Debug.Log(array.Length); //number of detected collisions
            Debug.Log(array.TotalLength); //actual array size
            Debug.Log(array[0]); //accessing array elements

            //pass the result to another function.
            Log(results);
        }

        private void Log(IReadonlyDynamicArray<RaycastHit> raycastHits)
        {
            foreach (var raycastHit in raycastHits)
            {
                Debug.Log(raycastHit.collider.name);
            }
        }
    }
}