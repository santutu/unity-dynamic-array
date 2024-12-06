namespace Santutu.Core.LengthArray.Runtime
{
    public struct AddLengthArray<T>
    {
        private LengthArray<T> _lengthArray;
        public int Index;

        public AddLengthArray(LengthArray<T> lengthArray)
        {
            Index = 0;
            _lengthArray = lengthArray;
            _lengthArray.Length = 0;
        }


        public void Add(T item)
        {
            if (Index + 1 > _lengthArray.TotalLength)
            {
                _lengthArray.ResizeMaintain(_lengthArray.TotalLength + _lengthArray.padding);
            }

            _lengthArray[Index] = item;
            Index++;
            
            _lengthArray.Length = Index;
        }
    }
}