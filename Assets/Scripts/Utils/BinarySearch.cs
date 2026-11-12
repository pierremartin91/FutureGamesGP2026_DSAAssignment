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

            if(employees[middle].lastExitFromEngineRoomDateTime >= lowerRange) {
                indexLowerRange = middle;
            }

            if(employees[middle].lastExitFromEngineRoomDateTime < lowerRange)
                indexLeft = middle + 1;
            else
                indexRight = middle - 1;
        }

        indexLeft = 0;
        indexRight = employees.Length - 1;

        middle = 0;

        while(indexLeft <= indexRight) {
            middle = (indexLeft + indexRight) / 2;

            if(employees[middle].lastExitFromEngineRoomDateTime <= upperRange) {
                indexUpperRange = middle;
            }

            if(employees[middle].lastExitFromEngineRoomDateTime > upperRange)
                indexRight = middle - 1;
            else
                indexLeft = middle + 1;

        }

        Debug.Log("Upper range - " + indexUpperRange + " Lower range - " + indexLowerRange);

        Employee[] searchedArray = new Employee[indexUpperRange - indexLowerRange + 1];

        int k = 0;

        for(int i = indexLowerRange; i <= indexUpperRange; i++) {
            searchedArray[k++] = employees[i];
        }

        return searchedArray;

    }
}
