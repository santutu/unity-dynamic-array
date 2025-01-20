using UnityEngine;
using Physics = UnityEngine.Physics;

namespace Santutu.Core.DynamicArray.Runtime
{
    public static partial class DPhysics
    {
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

                if (receiver.Capacity > count)
                {
                    break;
                }

                receiver.items = new RaycastHit[count + receiver.padding];
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

                if (receiver.Capacity > count)
                {
                    break;
                }

                receiver.items = new RaycastHit[count + receiver.padding];
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

                if (receiver.Capacity > count)
                {
                    break;
                }

                receiver.items = new RaycastHit[count + receiver.padding];
            }

            receiver.Length = count;

            return receiver;
        }


        public static IReadonlyDynamicArray<RaycastHit> SphereCastNonAlloc(
            Ray ray,
            float radius,
            DynamicArray<RaycastHit> receiver,
            float maxDistance,
            int layerMask = -1
        )
        {
            int count;

            while (true)
            {
                count = Physics.SphereCastNonAlloc(ray, radius, receiver.items, maxDistance, layerMask);

                if (receiver.Capacity > count)
                {
                    break;
                }

                receiver.items = new RaycastHit[count + receiver.padding];
            }

            receiver.Length = count;

            return receiver;
        }


        public static IReadonlyDynamicArray<Collider> OverlapBoxNonAlloc(
            Vector3 center,
            Vector3 halfExtents,
            DynamicArray<Collider> receiver,
            Quaternion orientation,
            int layerMask = -1
        )
        {
            int count;

            while (true)
            {
                count = Physics.OverlapBoxNonAlloc(center, halfExtents, receiver.items, orientation, layerMask);


                if (receiver.Capacity > count)
                {
                    break;
                }

                receiver.items = new Collider[count + receiver.padding];
            }

            receiver.Length = count;

            return receiver;
        }


        public static IReadonlyDynamicArray<Collider> OverlapSphereNonAlloc(
            Vector3 position,
            float radius,
            DynamicArray<Collider> receiver,
            int layerMask = -1
        )
        {
            int count;

            while (true)
            {
                count = Physics.OverlapSphereNonAlloc(position, radius, receiver.items, layerMask);

                if (receiver.Capacity > count)
                {
                    break;
                }

                receiver.items = new Collider[count + receiver.padding];
            }

            receiver.Length = count;

            return receiver;
        }

    


        public static IReadonlyDynamicArray<Collider> OverlapCapsuleNonAlloc(
            Vector3 point0,
            Vector3 point1,
            float radius,
            DynamicArray<Collider> receiver,
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
                    results: receiver.items,
                    layerMask: layerMask
                );


                if (receiver.Capacity > count)
                {
                    break;
                }

                receiver.items = new Collider[count + receiver.padding];
            }

            receiver.Length = count;

            return receiver;
        }
    }
}