using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Santutu.Core.DynamicArray.Runtime
{
    [Serializable]
    public class DynamicArray<T> : IReadonlyDynamicArray<T>, IReadOnlyCovariantDynamicArray<T>, IDisposable
    {
        [SerializeField] public T[] items;
        public int Count => Length;
        [field: SerializeField] public int Length { get; set; }

        public int padding = 30;
        public int Capacity => items.Length;

        public T this[int index] { get => items[index]; set => items[index] = value; }

        public DynamicArray(int capacity = 25)
        {
            items = new T[capacity];
            Length = 0;
        }


        public void Add(T item)
        {
            if (Capacity < Length + 1)
            {
                ResizeMaintain(Capacity + padding);
            }


            this[Length] = item;
            Length += 1;
        }

        public bool LessThan(int capacity)
        {
            return Capacity < capacity;
        }

        public bool ResizeNewIfLessThan(int capacity)
        {
            if (Capacity < capacity)
            {
                ResizeNew(capacity);
                return true;
            }

            return false;
        }

        public void ResizeNew(int capacity)
        {
            items = new T[capacity];
            Length = 0;
        }

        public void ResizeMaintain(int capacity)
        {
            Array.Resize(ref items, capacity);
        }

        public void Clear()
        {
            Length = 0;
            for (var i = 0; i < items.Length; i++)
            {
                items[i] = default;
            }
        }

        public void Assign(IEnumerable<T> items, int count)
        {
            if (count > Capacity)
            {
                this.items = new T[count + padding];
            }

            int i = 0;
            foreach (var item in items)
            {
                this[i] = item;
                i++;
                if (count <= i)
                {
                    break;
                }
            }

            Length = i;
        }

        public void Filter(Predicate<T> filter)
        {
            int insertIndex = 0;

            for (var i = 0; i < Count; i++)
            {
                var item = this[i];
                if (filter(item))
                {
                    this[insertIndex] = item;
                    insertIndex++;
                }
            }

            Length = insertIndex;
        }


        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }


        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            return GetEnumerator();
        }

        public DynamicArrayEnumerator<T> GetEnumerator()
        {
            return new DynamicArrayEnumerator<T>(this);
        }

        public static DynamicArray<T> Get()
        {
            return DynamicArrayPool<T>.Get();
        }

        public void Release()
        {
            DynamicArrayPool<T>.Return(this);
        }

        public void Dispose()
        {
            Release();
        }
    }
}