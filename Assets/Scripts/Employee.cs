using JetBrains.Annotations;
using System;
using System.Data;
using UnityEngine;




[Serializable]
public class Employee
{
    public string name;
    public int employeeId;
    public bool hasEngineRoomClearance;
    public string lastEntranceInEngineRoom;
    public string lastExitFromEngineRoom;

    public DateTime lastEntranceInEngineRoomDateTime;
    public DateTime lastExitFromEngineRoomDateTime;

    public void Initialise() {
        lastEntranceInEngineRoomDateTime = DateTime.Parse(lastEntranceInEngineRoom);
        lastExitFromEngineRoomDateTime = DateTime.Parse(lastExitFromEngineRoom);
    }
}

[Serializable]
public class EmployeeArray {
    public Employee[] employees;
}
