using Environment.Tasks;
using UnityEngine;
using System;
using System.Diagnostics;

[CreateAssetMenu(fileName = "SearchTask", menuName = "Scriptable Objects/SearchTask")]
public class SearchTask : Task {
    public override void Execute() {

        Employee[] testArray = BinarySearch.EmployeesWithinDateTimeRange(EmployeeManager.Instance.Employees,
            new DateTime(2234, 08, 07, 20, 44, 44),
            new DateTime(2234, 04, 07, 20, 44, 44));


        foreach(Employee e in testArray) {
            e.Initialise();
            UnityEngine.Debug.Log(e.name);
            UnityEngine.Debug.Log(e.lastExitFromEngineRoomDateTime);
        }

        UnityEngine.Debug.Log(testArray.Length);

    }
}
