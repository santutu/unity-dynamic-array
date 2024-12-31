Length Array
===

When using Physics.NonAlloc, you don't need to think about the array size.  
If the number of detected colliders exceeds the array size, the array will be automatically resized.


```csharp
//don't worry about the array size. It's a trivial and unnecessary.
LengthArray<RaycastHit> lengthArray = new();
 
//you can loop using foreach.
foreach (var hit in LengthPhysics.SphereCastNonAlloc(ray, 1, 1000, lengthArray))
{
    Debug.Log(hit.collider.name);
}
``
//the original style is also possible.``
for (var i = 0; i < LengthPhysics.SphereCastNonAlloc(ray, 1, 1000````, lengthArray).Length; i++)
{
    Debug.Log(lengthArray[i].collider.name);
}

Debug.Log(lengthArray.Length); //number of detected collisions
Debug.Log(lengthArray.TotalLength); //actual array size
Debug.Log(lengthArray[0]); //accessing array elements
            
```

Git install URL
---
```
https://github.com/santutu/unity-length-array.git?path=/Assets/Santutu/Core/LengthArray
```

OpenUPM Install
---
```
openupm add com.santutu.lengtharray
```
