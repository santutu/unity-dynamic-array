Background
---

1. Why should we pay attention to trivial matters? When using Physics.NonAlloc, determining the size of the array is usually unnecessary.

```
If the number of detected colliders exceeds the size of the array, the DynamicArray will automatically resize the array.
```

2. When executing Physics.NonAlloc method, the number of detected colliders and the actual colliders are handled separately as an int and an array[], making it inconvenient to use.

```
A DynamicArray instance holding this information would be more convenient to use.
```


3. For concise code.

```csharp
using var result = DPhysics.OverlapSphereNonAllocFromPool(transform.position, 3);
            
foreach (var collider in result)
{
    Debug.Log(collider.name);
}
```

Use Case
---

1. automatic resizing
```csharp
DynamicArray<RaycastHit> array = new();
//just call the method, and it will automatically resize the array.
DPhysics.SphereCastNonAlloc(ray, 1, 1000, array)
```

2. foreach loop

```csharp
var results = DPhysics.SphereCastNonAlloc(ray, 1, 1000, array);
foreach (var hit in results)
{
    Debug.Log(hit.collider.name);
}
```

3. for loop
```csharp
var results = DPhysics.SphereCastNonAlloc(ray, 1, 1000, array);

for (var i = 0; i < results.Length; i++)
{
    Debug.Log(array[i].collider.name);
}
```
4. passing the detected collider array as a parameter
```csharp
var results = DPhysics.SphereCastNonAlloc(ray, 1, 1000, array);
Log(results);
```
The detected colliders and their count can be accessed from anywhere using dynamicarray


5. from pool of dynamic array
```csharp

using var array = DynamicArray<Collider>.Get();
            
var results = DPhysics.OverlapSphereNonAlloc(transform.position, 1, array);

foreach (var collider in results)
{
    Debug.Log(collider.name);
}
            
```

6. shorthand
```csharp           
using var result = DPhysics.OverlapSphereNonAllocFromPool(transform.position, 3);
            
foreach (var collider in result)
{
    Debug.Log(collider.name);
}
```



Git install URL
---
```
https://github.com/santutu/unity-dynamic-array.git?path=/Assets/Santutu/Core/DynamicArray
```

