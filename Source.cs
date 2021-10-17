namespace Sorting
    {
        public static class CycleSort
        {
            public static void Sort(ref int[] array, SortingOrder order = SortingOrder.LowestToHighest)
            {
                if(order == SortingOrder.HighestToLowest)
                {
                    for (int i = 0; i < array.Length; i++)
                    {
                        int index = 0;
                        for (int j = i; j < array.Length; j++)
                        {
                            if (array[j] > array[index])
                            {
                                index = j;
                            }
                        }
                        int highestValue = array[index];
                        array[index] = array[i];
                        array[i] = highestValue;
                    }
                }
                else if(order == SortingOrder.LowestToHighest)
                {
                    for (int i = 0; i < array.Length; i++)
                    {
                        int index = 0;
                        for (int j = i; j < array.Length; j++)
                        {
                            if (array[j] < array[index])
                            {
                                index = j;
                            }
                        }
                        int highestValue = array[index];
                        array[index] = array[i];
                        array[i] = highestValue;
                    }
                }
                else
                {
                    throw new NotSupportedException("This order is not supported!");
                }
            }

            public enum SortingOrder
            {
                LowestToHighest,
                HighestToLowest
            }
        }
    }
