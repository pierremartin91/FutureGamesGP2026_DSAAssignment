using System;
using UnityEngine;
using UnityEngine.UIElements;

public class BinarySearch
{
    public static Employee[] EmployeesWithinDateTimeRange(Employee[] employees, DateTime lowerRange, DateTime upperRange) {

        int indexLowerRange = 0;
        int indexUpperRange = employees.Length - 1;

        int indexLeft = 0;
        int indexRight = employees.Length - 1;

        int middle = 0;

        while(indexLeft <= indexRight) {
            middle = (indexLeft + indexRight) / 2;

            if(employees[middle].lastEntranceInEngineRoomDateTime >= lowerRange) {
                indexLowerRange = middle;
            }

            if(employees[middle].lastEntranceInEngineRoomDateTime < lowerRange)
                indexLeft = middle + 1;
            else
                indexRight = middle - 1;
        }

        indexLeft = 0;
        indexRight = employees.Length - 1;

        middle = 0;

        while(indexLeft <= indexRight) {
            middle = (indexLeft + indexRight) / 2;

            if(employees[middle].lastEntranceInEngineRoomDateTime <= upperRange) {
                indexUpperRange = middle;
            }

            if(employees[middle].lastEntranceInEngineRoomDateTime > upperRange)
                indexLeft = middle + 1;
            else
                indexRight = middle - 1;
        }

        Employee[] searchedArray = new Employee[indexUpperRange - indexLowerRange + 1];

        int k = 0;

        for(int i = indexLowerRange; i <= indexUpperRange; i++) {
            searchedArray[k++] = employees[i];
        }

        return searchedArray;

    }
}
