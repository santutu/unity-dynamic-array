using UnityEngine;
using Physics = UnityEngine.Physics;

namespace Santutu.Core.DynamicArray.Runtime
{
    public static class DPhysics
    {
        public static int NewPadding = 40;


        public static IReadonlyDynamicArray<RaycastHit> BoxCastNonAlloc(
            Vector3 center,
            Vector3 halfExtents,
            Vector3 direction,
            DynamicArray<RaycastHit> receiver,
            Quaternion orientation,
            float maxDistance,
            int layerMask = -1
        )
        {
            int count;

            while (true)
            {
                count = Physics.BoxCastNonAlloc(
                    center,
                    halfExtents,
                    direction,
                    receiver.items,
                    orientation,
                    maxDistance,
                    layerMask
                );

                if (receiver.TotalLength > count)
                {
                    break;
                }

                receiver.items = new RaycastHit[count + NewPadding];
            }

            receiver.Length = count;

            return receiver;
        }


        public static IReadonlyDynamicArray<RaycastHit> CapsuleCastNonAlloc(
            Vector3 point1,
            Vector3 point2,
            float radius,
            Vector3 direction,
            DynamicArray<RaycastHit> receiver,
            float maxDistance,
            int layerMask = -1
        )
        {
            int count;

            while (true)
            {
                count = Physics.CapsuleCastNonAlloc(
                    point1,
                    point2,
                    radius,
                    direction,
                    receiver.items,
                    maxDistance,
                    layerMask
                );

                if (receiver.TotalLength > count)
                {
                    break;
                }

                receiver.items = new RaycastHit[count + NewPadding];
            }

            receiver.Length = count;

            return receiver;
        }

        public static IReadonlyDynamicArray<RaycastHit> RaycastNonAlloc(
            Vector3 origin,
            Vector3 direction,
            DynamicArray<RaycastHit> receiver,
            float maxDistance,
            int layerMask = -1
        )
        {
            int count;

            while (true)
            {
                count = Physics.RaycastNonAlloc(origin, direction, receiver.items, maxDistance, layerMask);

                if (receiver.TotalLength > count)
                {
                    break;
                }

                receiver.items = new RaycastHit[count + NewPadding];
            }

            receiver.Length = count;

            return receiver;
        }


        public static IReadonlyDynamicArray<RaycastHit> SphereCastNonAlloc(
            Ray ray,
            float radius,
            float maxDistance,
            DynamicArray<RaycastHit> receiver,
            int layerMask = -1
        )
        {
            int count;

            while (true)
            {
                count = Physics.SphereCastNonAlloc(ray, radius, receiver.items, maxDistance, layerMask);

                if (receiver.TotalLength > count)
                {
                    break;
                }

                receiver.items = new RaycastHit[count + NewPadding];
            }

            receiver.Length = count;

            return receiver;
        }


        public static IReadonlyDynamicArray<Collider> OverlapBoxNonAlloc(
            Vector3 center,
            Vector3 halfExtents,
            DynamicArray<Collider> results,
            Quaternion orientation,
            int layerMask = -1
        )
        {
            int count;

            while (true)
            {
                count = Physics.OverlapBoxNonAlloc(center, halfExtents, results.items, orientation, layerMask);


                if (results.TotalLength > count)
                {
                    break;
                }

                results.items = new Collider[count + NewPadding];
            }

            results.Length = count;

            return results;
        }


        public static IReadonlyDynamicArray<Collider> OverlapSphereNonAlloc(
            Vector3 position,
            float radius,
            DynamicArray<Collider> results,
            int layerMask = -1
        )
        {
            int count;

            while (true)
            {
                count = Physics.OverlapSphereNonAlloc(position, radius, results.items, layerMask);

                if (results.TotalLength > count)
                {
                    break;
                }

                results.items = new Collider[count + NewPadding];
            }

            results.Length = count;

            return results;
        }


        public static IReadonlyDynamicArray<Collider> OverlapCapsuleNonAlloc(
            Vector3 point0,
            Vector3 point1,
            float radius,
            DynamicArray<Collider> results,
            int layerMask = -1
        )
        {
            int count;

            while (true)
            {
                count = Physics.OverlapCapsuleNonAlloc(
                    point0: point0,
                    point1: point1,
                    radius: radius,
                    results: results.items,
                    layerMask: layerMask
                );


                if (results.TotalLength > count)
                {
                    break;
                }

                results.items = new Collider[count + NewPadding];
            }

            results.Length = count;

            return results;
        }
    }
}