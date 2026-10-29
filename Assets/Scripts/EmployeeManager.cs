using UnityEngine;

public class EmployeeManager : MonoBehaviour
{
    public static EmployeeManager Instance;

    public Employee[] Employees = null;

    public void Awake() {
        Instance = this;
    }
}
