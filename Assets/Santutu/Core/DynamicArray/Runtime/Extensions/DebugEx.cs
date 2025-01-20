using UnityEngine;

namespace Santutu.Core.DynamicArray.Runtime.Extensions
{
    internal static class DebugEx
    {
        public static void DebugWireSphere(
            Vector3 position,
            float radius,
            Color color,
            float duration = 0,
            bool depthTest = false
        )
        {
            const int segments = 36;

            DrawCircle(position, Vector3.forward, Vector3.up, radius, segments, color, duration, depthTest);
            DrawCircle(position, Vector3.up, Vector3.right, radius, segments, color, duration, depthTest);
            DrawCircle(position, Vector3.right, Vector3.forward, radius, segments, color, duration, depthTest);
        }

        public static void DrawCircle(
            Vector3 center,
            Vector3 axis1,
            Vector3 axis2,
            float radius,
            int segments,
            Color color,
            float duration,
            bool depthTest
        )
        {
            float angleStep = 360f / segments;
            for (int i = 0; i < segments; i++)
            {
                float angle1 = i * angleStep * Mathf.Deg2Rad;
                float angle2 = (i + 1) * angleStep * Mathf.Deg2Rad;

                Vector3 point1 = center + (Mathf.Cos(angle1) * axis1 + Mathf.Sin(angle1) * axis2) * radius;
                Vector3 point2 = center + (Mathf.Cos(angle2) * axis1 + Mathf.Sin(angle2) * axis2) * radius;

                Debug.DrawLine(point1, point2, color, duration, depthTest);
            }
        }
        
        //todo...
    }
}