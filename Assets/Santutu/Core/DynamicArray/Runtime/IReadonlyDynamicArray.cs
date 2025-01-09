using System.Collections.Generic;

namespace Santutu.Core.DynamicArray.Runtime
{
    public interface IReadonlyDynamicArray<T> : IEnumerable<T>
    {
        public int Count { get; }
        public int Length { get; set; }
        public int TotalLength { get; }
        public T this[int index] { get; }

        public new DynamicArrayEnumerator<T> GetEnumerator();
    }
}