using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Santutu.Core.DynamicArray.Runtime
{
    [Serializable]
    public class DynamicArray<T> : IReadonlyDynamicArray<T>, IReadOnlyCovariantDynamicArray<T>
    {
        [SerializeField] public T[] items;
        public int Count => Length;
        [field: SerializeField] public int Length { get; set; }

        public int padding = 5;
        public int TotalLength => items.Length;

        public DynamicArray(int capacity = 25)
        {
            items = new T[capacity];
            Length = 0;
        }

        public void Clear()
        {
            Length = 0;
            for (var i = 0; i < items.Length; i++)
            {
                items[i] = default;
            }
        }

        public void Add(T item)
        {
            if (TotalLength < Length + 1)
            {
                ResizeMaintain(TotalLength + padding);
            }


            this[Length] = item;
            Length += 1;
        }

        public bool LessThan(int capacity)
        {
            return TotalLength < capacity;
        }

        public bool ResizeNewIfLessThan(int capacity)
        {
            if (TotalLength < capacity)
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
            var original = items;
            items = new T[capacity];

            for (var i = 0; i < items.Length && i < original.Length; i++)
            {
                items[i] = original[i];
            }
        }


        public T this[int index] { get => items[index]; set => items[index] = value; }


        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            return GetEnumerator();
        }

        public DynamicArrayEnumerator<T> GetEnumerator()
        {
            return new DynamicArrayEnumerator<T>(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Assign(IEnumerable<T> items, int count)
        {
            if (count > TotalLength)
            {
                this.items = new T[count + padding];
            }

            int i = 0;
            foreach (var item in items)
            {
                this[i] = item;
                i++;
            }

            Length = count;
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
    }
}