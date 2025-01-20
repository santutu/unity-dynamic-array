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
            Debug.Log(array.Capacity); //actual array size
            Debug.Log(array[0]); //accessing array elements

            //pass the result to another function.
            Log(results);


            //pool
            using var array2 = DynamicArray<Collider>.Get();
            
            var results3 = DPhysics.OverlapSphereNonAlloc(transform.position, 1, array2);
            
            foreach (var collider in results3)
            {
                Debug.Log(collider.name);
            }

            //pool shorthand
            using var result4 = DPhysics.OverlapSphereNonAllocFromPool(transform.position, 1);
            
            foreach (var collider in result4)
            {
                Debug.Log(collider.name);
            }
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