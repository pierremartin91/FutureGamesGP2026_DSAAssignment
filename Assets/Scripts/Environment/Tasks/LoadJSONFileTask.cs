using System.Threading.Tasks;
using Unity.VisualScripting;
using UnityEngine;

namespace Environment.Tasks {
    [CreateAssetMenu(fileName = "LoadJson Task", menuName = "LoadJson Task")]
    public class LoadJSONFileTask : Task {
        [SerializeField] TextAsset jsonFile;

        public override void Execute() {
            //Employee[] Employees = JsonUtility.FromJson<EmployeeArray>(jsonFile.text).employees;

            EmployeeManager.Instance.Employees = JsonUtility.FromJson<EmployeeArray>(jsonFile.text).employees;

            foreach(Employee e in EmployeeManager.Instance.Employees) {
                e.Initialise();
                Debug.Log(e.name);
                Debug.Log(e.lastEntranceInEngineRoomDateTime);
            }
        }
    }
}
