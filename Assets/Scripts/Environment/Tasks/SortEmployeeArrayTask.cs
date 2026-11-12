using UnityEngine;



namespace Environment.Tasks {
    [CreateAssetMenu(fileName = "SortEmployeeArrayTask", menuName = "Scriptable Objects/SortEmployeeArrayTask")]
    public class SortEmployeeArrayTask : Task {
        public override void Execute() {

            MergSort.SortEmployeeArrayByExitDateTime(EmployeeManager.Instance.Employees, 0, EmployeeManager.Instance.Employees.Length - 1);
        }
    }
}
