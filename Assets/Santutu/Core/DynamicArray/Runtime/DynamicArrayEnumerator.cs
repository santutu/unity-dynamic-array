using System.Collections;
using System.Collections.Generic;

namespace Santutu.Core.DynamicArray.Runtime
{
    public struct DynamicArrayEnumerator<T> : IEnumerator<T>
    {
        private readonly DynamicArray<T> _array;

        private int _current;

        public DynamicArrayEnumerator(DynamicArray<T> array)
        {
            _array = array;
            _current = -1;
        }

        public bool MoveNext()
        {
            _current += 1;
            return _current < _array.Length;
        }

        public void Reset()
        {
            _current = -1;
        }

        public T Current => _array.items[_current];

        object IEnumerator.Current => Current;

        public void Dispose()
        {
        }
    }
}