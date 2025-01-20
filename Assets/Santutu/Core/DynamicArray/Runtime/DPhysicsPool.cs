using UnityEngine;

namespace Santutu.Core.DynamicArray.Runtime
{
    public static partial class DPhysics
    {
        public static IReadonlyDynamicArray<RaycastHit> BoxCastNonAllocFromPool(
            Vector3 center,
            Vector3 halfExtents,
            Vector3 direction,
            Quaternion orientation,
            float maxDistance,
            int layerMask = -1
        )
        {
            return BoxCastNonAlloc(center, halfExtents, direction, DynamicArray<RaycastHit>.Get(), orientation, maxDistance, layerMask);
        }

        public static IReadonlyDynamicArray<RaycastHit> BoxCastNonAlloc(
            Vector3 center,
            Vector3 halfExtents,
            Vector3 direction,
            Quaternion orientation,
            float maxDistance,
            int layerMask = -1
        )
        {
            return BoxCastNonAlloc(center, halfExtents, direction, DynamicArray<RaycastHit>.Get(), orientation, maxDistance, layerMask);
        }


        public static IReadonlyDynamicArray<RaycastHit> CapsuleCastNonAllocFromPool(
            Vector3 point1,
            Vector3 point2,
            float radius,
            Vector3 direction,
            float maxDistance,
            int layerMask = -1
        )
        {
            return CapsuleCastNonAlloc(point1, point2, radius, direction, DynamicArray<RaycastHit>.Get(), maxDistance, layerMask);
        }

        
        
        public static IReadonlyDynamicArray<RaycastHit> CapsuleCastNonAlloc(
            Vector3 point1,
            Vector3 point2,
            float radius,
            Vector3 direction,
            float maxDistance,
            int layerMask = -1
        )
        {
            return CapsuleCastNonAlloc(point1, point2, radius, direction, DynamicArray<RaycastHit>.Get(), maxDistance, layerMask);
        }

        public static IReadonlyDynamicArray<RaycastHit> RaycastNonAllocFromPool(
            Vector3 origin,
            Vector3 direction,
            float maxDistance,
            int layerMask = -1
        )
        {
            return RaycastNonAlloc(origin, direction, DynamicArray<RaycastHit>.Get(), maxDistance, layerMask);
        }

        
        
        public static IReadonlyDynamicArray<RaycastHit> RaycastNonAlloc(
            Vector3 origin,
            Vector3 direction,
            float maxDistance,
            int layerMask = -1
        )
        {
            return RaycastNonAlloc(origin, direction, DynamicArray<RaycastHit>.Get(), maxDistance, layerMask);
        }

        public static IReadonlyDynamicArray<RaycastHit> SphereCastNonAllocFromPool(
            Ray ray,
            float radius,
            float maxDistance,
            int layerMask = -1
        )
        {
            return SphereCastNonAlloc(ray, radius, DynamicArray<RaycastHit>.Get(), maxDistance, layerMask);
        }


        public static IReadonlyDynamicArray<RaycastHit> SphereCastNonAlloc(
            Ray ray,
            float radius,
            float maxDistance,
            int layerMask = -1
        )
        {
            return SphereCastNonAlloc(ray, radius, DynamicArray<RaycastHit>.Get(), maxDistance, layerMask);
        }

        public static IReadonlyDynamicArray<Collider> OverlapBoxNonAllocFromPool(
            Vector3 center,
            Vector3 halfExtents,
            Quaternion orientation,
            int layerMask = -1
        )
        {
            return OverlapBoxNonAlloc(center, halfExtents, DynamicArray<Collider>.Get(), orientation, layerMask);
        }


        public static IReadonlyDynamicArray<Collider> OverlapBoxNonAlloc(
            Vector3 center,
            Vector3 halfExtents,
            Quaternion orientation,
            int layerMask = -1
        )
        {
            return OverlapBoxNonAlloc(center, halfExtents, DynamicArray<Collider>.Get(), orientation, layerMask);
        }

        public static IReadonlyDynamicArray<Collider> OverlapSphereNonAllocFromPool(
            Vector3 position,
            float radius,
            int layerMask = -1
        )
        {
            return OverlapSphereNonAlloc(position, radius, DynamicArray<Collider>.Get(), layerMask);
        }
        
        
        public static IReadonlyDynamicArray<Collider> OverlapSphereNonAlloc(
            Vector3 position,
            float radius,
            int layerMask = -1
        )
        {
            return OverlapSphereNonAlloc(position, radius, DynamicArray<Collider>.Get(), layerMask);
        }

        public static IReadonlyDynamicArray<Collider> OverlapCapsuleNonAllocFromPool(
            Vector3 point0,
            Vector3 point1,
            float radius,
            int layerMask = -1
        )
        {
            return OverlapCapsuleNonAlloc(point0, point1, radius, DynamicArray<Collider>.Get(), layerMask);
        }
        
        

        public static IReadonlyDynamicArray<Collider> OverlapCapsuleNonAlloc(
            Vector3 point0,
            Vector3 point1,
            float radius,
            int layerMask = -1
        )
        {
            return OverlapCapsuleNonAlloc(point0, point1, radius, DynamicArray<Collider>.Get(), layerMask);
        }
    }
}