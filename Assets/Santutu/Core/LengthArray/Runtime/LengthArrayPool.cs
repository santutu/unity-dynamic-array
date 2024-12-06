using System.Collections.Generic;

namespace Santutu.Core.LengthArray.Runtime
{
    public static class LengthArrayPool<T>
    {
        private static List<LengthArray<T>> inUsePool = new();
        private static List<LengthArray<T>> availablePool = new();

        public static LengthArray<T> Get(int minCount)
        {
            LengthArray<T> lengthArray = null;

            for (var i = 0; i < availablePool.Count; i++)
            {
                lengthArray = availablePool[i];
                if (lengthArray.TotalLength >= minCount)
                {
                    availablePool.Remove(lengthArray);
                    inUsePool.Add(lengthArray);
                    return lengthArray;
                }
            }


            if (availablePool.Count >= 1)
            {
                lengthArray = availablePool[0];
                lengthArray.ResizeNew(minCount);

                availablePool.Remove(lengthArray);
                inUsePool.Add(lengthArray);

                return lengthArray;
            }

            lengthArray = new LengthArray<T>(minCount);
            inUsePool.Add(lengthArray);

            return lengthArray;
        }
    }
}