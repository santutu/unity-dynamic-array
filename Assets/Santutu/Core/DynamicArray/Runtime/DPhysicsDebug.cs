using Santutu.Core.DynamicArray.Runtime.Extensions;
using UnityEngine;

namespace Santutu.Core.DynamicArray.Runtime
{
    public static partial class DPhysics
    {
        public static IReadonlyDynamicArray<Collider> OverlapSphereNonAllocDebug(
            Vector3 position,
            float radius,
            DynamicArray<Collider> receiver,
            int layerMask = -1,
            float duration = 0,
            Color? color = null,
            Color? hitColor = null
        )
        {
            OverlapSphereNonAlloc(position, radius, receiver, layerMask);
#if UNITY_EDITOR
            var collided = receiver.Length > 0;
            DebugEx.DebugWireSphere(position, radius, !collided ? (color ?? Color.green) : (hitColor ?? Color.red), duration);
#endif
            return receiver;
        }
        
        public static IReadonlyDynamicArray<Collider> OverlapSphereNonAllocDebug(
            Vector3 position,
            float radius,
            int layerMask = -1,
            float duration = 0,
            Color? color = null,
            Color? hitColor = null
        )
        {
            var receiver= OverlapSphereNonAlloc(position, radius, layerMask);
#if UNITY_EDITOR
            var collided = receiver.Length > 0;
            DebugEx.DebugWireSphere(position, radius, !collided ? (color ?? Color.green) : (hitColor ?? Color.red), duration);
#endif
            return receiver;
        }
        
        //todo...
    }
}