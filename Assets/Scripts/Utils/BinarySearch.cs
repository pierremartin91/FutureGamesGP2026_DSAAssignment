using System;
using UnityEngine;

public class BinarySearch
{
    public static Employee[] EmployeesWithinDateTimeRange(Employee[] employees,  DateTime lowerRange, DateTime upperRange) {

        int low = 0, high = employees.Length - 1;

        // need to find employee with datetime that is at the TOP of the range and at the BOTTOM
        // maybe run two binary searches for top and bottom, find the index, and add all employees to
        // said range with a simple comparison

        /*
         * the problem is that the ranges supplied might not match up 1:1 with employees, so they need to be
         * stored in their own DateTime variables
         * 
         * could easily bruteforce this but ideally we want an elegant solution to find the top and bottom indexes
         * just save the index of employee who currently meets the range comparison 
         * 
         * if lowerRange < employee.lastExit
         * 
         * 
         * 
         * 
         */


        while(low <= high) {
            int median = low + (low + high) / 2;

            if(employees[median].lastExitFromEngineRoomDateTime == dateTime)
                return employees[median];

            if(employees[median].lastExitFromEngineRoomDateTime < dateTime)
                low = median + 1;
            else
                low = median - 1;
        }

        return null;
    }

    private static Employee 
}
