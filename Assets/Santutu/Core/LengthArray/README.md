Length Array
===

When using the non-alloc method, it does not return the number of colliders but instead returns an array that includes the collision count information.


```csharp
foreach (var hit in LengthPhysics.SphereCastNonAlloc(ray, 1, 1000, lengthArray))
{
    Debug.Log(hit.collider.name);
}
```

See Sample
---
https://github.com/santutu/unity-length-array/blob/main/Assets/Santutu/Core/LengthArray/Samples/Sample.cs