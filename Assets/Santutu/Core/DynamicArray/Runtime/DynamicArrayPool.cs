using System.Collections.Generic;

namespace Santutu.Core.DynamicArray.Runtime
{
    public static class DynamicArrayPool<T>
    {
        private static readonly Stack<DynamicArray<T>> Pool = new Stack<DynamicArray<T>>();

        public static DynamicArray<T> Get()
        {
            if (Pool.Count > 0)
            {
                return Pool.Pop();
            }

            return new DynamicArray<T>();
        }

        public static void Return(DynamicArray<T> array)
        {
            array.Length = 0;
            Pool.Push(array);
        }

        public static void Clear()
        {
            Pool.Clear();
        }
    }
}