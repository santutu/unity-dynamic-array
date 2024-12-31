using UnityEngine;
using Physics = UnityEngine.Physics;
using System;

namespace Santutu.Core.LengthArray.Runtime
{
    public static class LengthPhysics
    {
        public static readonly int NewPadding = 40;


        public static IReadonlyLengthArray<RaycastHit> BoxCastNonAlloc(
            Vector3 center,
            Vector3 halfExtents,
            Vector3 direction,
            LengthArray<RaycastHit> receiver,
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
                
                Array.Resize(ref receiver.items, count + NewPadding);
            }

            receiver.Length = count;

            return receiver;
        }


        public static IReadonlyLengthArray<RaycastHit> CapsuleCastNonAlloc(
            Vector3 point1,
            Vector3 point2,
            float radius,
            Vector3 direction,
            LengthArray<RaycastHit> receiver,
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

                Array.Resize(ref receiver.items, count + NewPadding);
            }

            receiver.Length = count;

            return receiver;
        }

        public static IReadonlyLengthArray<RaycastHit> RaycastNonAlloc(
            Vector3 origin,
            Vector3 direction,
            LengthArray<RaycastHit> receiver,
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

                Array.Resize(ref receiver.items, count + NewPadding);
            }

            receiver.Length = count;

            return receiver;
        }


        public static IReadonlyLengthArray<RaycastHit> SphereCastNonAlloc(
            Ray ray,
            float radius,
            float maxDistance,
            LengthArray<RaycastHit> receiver,
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

                Array.Resize(ref receiver.items, count + NewPadding);
            }

            receiver.Length = count;

            return receiver;
        }


        public static IReadonlyLengthArray<Collider> OverlapBoxNonAlloc(
            Vector3 center,
            Vector3 halfExtents,
            LengthArray<Collider> receiver,
            Quaternion orientation,
            int layerMask = -1
        )
        {
            int count;

            while (true)
            {
                count = Physics.OverlapBoxNonAlloc(center, halfExtents, receiver.items, orientation, layerMask);


                if (receiver.TotalLength > count)
                {
                    break;
                }

                Array.Resize(ref receiver.items, count + NewPadding);
            }

            receiver.Length = count;

            return receiver;
        }


        public static IReadonlyLengthArray<Collider> OverlapSphereNonAlloc(
            Vector3 position,
            float radius,
            LengthArray<Collider> receiver,
            int layerMask = -1
        )
        {
            int count;

            while (true)
            {
                count = Physics.OverlapSphereNonAlloc(position, radius, receiver.items, layerMask);

                if (receiver.TotalLength > count)
                {
                    break;
                }
                
                Array.Resize(ref receiver.items, count + NewPadding);
            }

            receiver.Length = count;

            return receiver;
        }


        public static IReadonlyLengthArray<Collider> OverlapCapsuleNonAlloc(
            Vector3 point0,
            Vector3 point1,
            float radius,
            LengthArray<Collider> receiver,
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


                if (receiver.TotalLength > count)
                {
                    break;
                }

                Array.Resize(ref receiver.items, count + NewPadding);
            }

            receiver.Length = count;

            return receiver;
        }
    }
}