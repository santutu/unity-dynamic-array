using System.Collections;
using System.Collections.Generic;

namespace Santutu.Core.DynamicArray.Runtime
{
    public struct DynamicArrayEnumerator<T> : IEnumerator<T>
    {
        private DynamicArray<T> _colliderReceiver;

        private int _current;

        public DynamicArrayEnumerator(DynamicArray<T> colliderReceiver)
        {
            _colliderReceiver = colliderReceiver;
            _current = -1;
        }

        public bool MoveNext()
        {
            _current += 1;
            return _current < _colliderReceiver.Length;
        }

        public void Reset()
        {
            _current = -1;
        }

        public T Current => _colliderReceiver.items[_current];

        object IEnumerator.Current => Current;

        public void Dispose()
        {
        }
    }
}