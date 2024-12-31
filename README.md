Background
---

1. When executing Physics.NonAlloc method, the number of detected colliders and the actual colliders are handled separately as an int and an array[], making it inconvenient to use.

```
A LengthArray instance holding this information would be more convenient to use.
```

2. Why should we pay attention to trivial matters?

```
When using Physics.NonAlloc, determining the size of the array is usually unnecessary.
If the number of detected colliders exceeds the size of the array, the LengthArray will automatically resize the array.
```


Use Case
---

automatic resizing
```csharp
LengthArray<RaycastHit> array = new();
//just call the method, and it will automatically resize the array.
LengthPhysics.SphereCastNonAlloc(ray, 1, 1000, array)
```

foreach loop

```csharp
var results = LengthPhysics.SphereCastNonAlloc(ray, 1, 1000, array);
foreach (var hit in results)
{
    Debug.Log(hit.collider.name);
}
```

for loop
```csharp
var results = LengthPhysics.SphereCastNonAlloc(ray, 1, 1000, array);

for (var i = 0; i < results.Length; i++)
{
    Debug.Log(array[i].collider.name);
}
```
passing the detected collider array as a parameter
```csharp
var results = LengthPhysics.SphereCastNonAlloc(ray, 1, 1000, array);
Log(results);
```
The detected colliders and their count can be accessed from anywhere using lengtharray


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
