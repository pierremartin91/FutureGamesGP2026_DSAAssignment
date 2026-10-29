using System;
using System.Diagnostics;
using UnityEngine;

public static class MergSort {
    public static void SortEmployeeArrayByExitDateTime(Employee[] array, int left, int right) {
        if(left < right) {
            int middle = left + (right - left) / 2;

            SortEmployeeArrayByExitDateTime(array, left, middle);
            SortEmployeeArrayByExitDateTime(array, middle + 1, right);

            merge(array, left, middle, right);
        }
    }

    private static void merge(Employee[] array, int left, int middle, int right) {
        int leftArraySize = middle - left + 1;      // if middle was 1 and left was 0, that's 2 elements, thus the need for the + 1
        int rightArraySize = right - middle;        // 3 - 1 would give us 2 which is correct

        Employee[] leftSide = new Employee[leftArraySize];
        Employee[] rightSide = new Employee[rightArraySize];

        
        int i, j;

        for(i = 0; i < leftArraySize; i++)
            leftSide[i] = array[left + i];          // will go up to the middle from the left
        for(j = 0; j < rightArraySize; j++)
            rightSide[j] = array[middle + 1 + j];   // will go up to the right from one after the middle

        i = 0;
        j = 0;

        int k = left;

        while(i < leftArraySize && j < rightArraySize) {
            if(leftSide[i].lastExitFromEngineRoomDateTime <= rightSide[j].lastExitFromEngineRoomDateTime) {
                array[k++] = leftSide[i++];
            }
            else {
                array[k++] = rightSide[j++];
            }
        }

        while(i < leftArraySize)
            array[k++] = leftSide[i++];

        while(j < rightArraySize)
            array[k++] = rightSide[j++];

        for(int x = 0; x < array.Length; ++x)
            Console.Write(array[x] + " ");
        Console.WriteLine();

    }
}
