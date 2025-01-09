Background
---

1. When executing Physics.NonAlloc method, the number of detected colliders and the actual colliders are handled separately as an int and an array[], making it inconvenient to use.

```
A DynamicArray instance holding this information would be more convenient to use.
```

2. Why should we pay attention to trivial matters?

```
When using Physics.NonAlloc, determining the size of the array is usually unnecessary.
If the number of detected colliders exceeds the size of the array, the DynamicArray will automatically resize the array.
```


Use Case
---

automatic resizing
```csharp
DynamicArray<RaycastHit> array = new();
//just call the method, and it will automatically resize the array.
DPhysics.SphereCastNonAlloc(ray, 1, 1000, array)
```

foreach loop

```csharp
var results = DPhysics.SphereCastNonAlloc(ray, 1, 1000, array);
foreach (var hit in results)
{
    Debug.Log(hit.collider.name);
}
```

for loop
```csharp
var results = DPhysics.SphereCastNonAlloc(ray, 1, 1000, array);

for (var i = 0; i < results.Length; i++)
{
    Debug.Log(array[i].collider.name);
}
```
passing the detected collider array as a parameter
```csharp
var results = DPhysics.SphereCastNonAlloc(ray, 1, 1000, array);
Log(results);
```
The detected colliders and their count can be accessed from anywhere using dynamicarray


Git install URL
---
```
https://github.com/santutu/unity-dynamic-array.git?path=/Assets/Santutu/Core/DynamicArray
```

