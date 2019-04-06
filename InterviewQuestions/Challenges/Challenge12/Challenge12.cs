using System.Collections.Generic;

namespace InterviewQuestions.Challenges.Challenge12
{
    public static class SorterClass
    {
        public static void QuickSort(int[] data)
        {
            // - Pick a pivot between a start and end index
            // - Put the rest of the items between the indexes in two partitions: less than the pivot
            // and greater than the pivot
            // - Insert the partitions back into the array with the pivot in between them.
            // - Repeat for the two partitions 

            QuickSort(data, 0, data.Length - 1);
        }

        private static void QuickSort(int[] data, int startIndex, int endIndex)
        {
            // Break out if end index is less than start index
            if (endIndex <= startIndex)
            {
                return;
            }

            // Set pivot as end index
            int pivot = data[endIndex];

            // Partition all the numbers between the indexes, not including the pivot.
            // Add them into either a smaller or larger partition
            List<int> smallerPartition = new List<int>();
            List<int> largerPartition = new List<int>();
            for (int i = startIndex; i < endIndex; i++)
            {
                int number = data[i];
                if (number < pivot)
                {
                    smallerPartition.Add(number);
                }
                else
                {
                    largerPartition.Add(number);
                }
            }

            // Insert the smaller partition back into the data
            int count = 0;
            for (int i = startIndex; i < startIndex + smallerPartition.Count; i++)
            {
                data[i] = smallerPartition[count];
                count++;
            }

            // Insert the pivot back into the data
            int newPivotIndex = startIndex + smallerPartition.Count;
            data[newPivotIndex] = pivot;
            newPivotIndex++;

            // Insert the larger partition into the data
            count = 0;
            for (int i = newPivotIndex; i < newPivotIndex + largerPartition.Count; i++)
            {
                data[i] = largerPartition[count];
                count++;
            }

            newPivotIndex--;

            // Quick sort the data around the pivot, not including the new pivot
            QuickSort(data, startIndex, newPivotIndex - 1);
            QuickSort(data, newPivotIndex + 1, endIndex);
        }

        public static void MergeSort(int[] data)
        {
            // Divide the data into smaller sublists
            // Merge the sublists with adjacent sublists and insert back into the main data structure

            MergeSort(data, 0, data.Length - 1);
        }

        private static int[] MergeSort(int[] data, int startIndex, int endIndex)
        {
            if (endIndex <= startIndex)
            {
                return new[] {data[startIndex]};
            }

            int partition = (startIndex + endIndex) / 2;

            int[] sublistLeft = MergeSort(data, startIndex, partition - 1);
            int[] sublistRight = MergeSort(data, partition + 1, endIndex);

            int[] mergedData = new int[sublistLeft.Length + sublistRight.Length];
            
            int leftCount = 0;
            int rightCount = 0;
            int mergedCount = 0;

            while (leftCount < sublistLeft.Length && rightCount < sublistRight.Length)
            {
                if (sublistLeft[leftCount] < sublistRight[rightCount])
                {
                    mergedData[mergedCount++] = sublistLeft[leftCount++];
                }
                else
                {
                    mergedData[mergedCount++] = sublistRight[rightCount++];
                }
            }

            while (leftCount < sublistLeft.Length)
            {
                mergedData[mergedCount++] = sublistLeft[leftCount++];
            }
            while (rightCount < sublistRight.Length)
            {
                mergedData[mergedCount++] = sublistRight[rightCount++];
            }

            return mergedData;
        }
    }
}