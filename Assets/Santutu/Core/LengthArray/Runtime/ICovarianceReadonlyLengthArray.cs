using System.Collections.Generic;

namespace Santutu.Core.LengthArray.Runtime
{
    public interface ICovarianceReadonlyLengthArray<out T> : IEnumerable<T>
    {
        public int Count { get; }
        public int Length { get; set; }
        public int TotalLength { get; }
        public T this[int index] { get; }
    }
}