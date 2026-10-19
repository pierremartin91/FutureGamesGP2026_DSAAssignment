using System.Threading.Tasks;
using Unity.VisualScripting;
using UnityEngine;

namespace Environment.Tasks {
    [CreateAssetMenu(fileName = "LoadJson Task", menuName = "LoadJson Task")]
    public class LoadJSONFileTask : Task {
        [SerializeField] TextAsset jsonFile;

        public override void Execute() {
            Employee[] employees = JsonUtility.FromJson<EmployeeArray>(jsonFile.text).employees;


            foreach(Employee e in employees) {
                e.Initialise();
                Debug.Log(e.name);
                Debug.Log(e.lastEntranceInEngineRoomDateTime);
            }
        }
    }
}
