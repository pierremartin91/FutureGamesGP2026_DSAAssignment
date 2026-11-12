using Environment.Tasks;
using UnityEngine;
using System;
using System.Diagnostics;

[CreateAssetMenu(fileName = "SearchTask", menuName = "Scriptable Objects/SearchTask")]
public class SearchTask : Task {
    public override void Execute() {

        UnityEngine.Debug.Log("BEGGINING BINARY SEARCH TASK");

        Stopwatch stopwatch = new Stopwatch();

        stopwatch.Start();

        Employee[] arrayOutput = BinarySearch.EmployeesWithinDateTimeRange(EmployeeManager.Instance.Employees,
                new DateTime(2234, 8, 9, 22, 00, 00),
                new DateTime(2234, 8, 9, 23, 00, 00));

        stopwatch.Stop();

        foreach(Employee e in arrayOutput) {
            UnityEngine.Debug.Log(e.name + ":");
            UnityEngine.Debug.Log("Last Entrance: " + e.lastEntranceInEngineRoomDateTime);
            UnityEngine.Debug.Log("Last Exit: " + e.lastExitFromEngineRoomDateTime);
        }

        UnityEngine.Debug.Log(arrayOutput.Length);

        UnityEngine.Debug.Log(stopwatch.ElapsedTicks);
    }
}
