using System;
using System.Diagnostics;
using UnityEngine;
using Utils;


namespace Environment.Tasks {
    [CreateAssetMenu(fileName = "SearchBinaryTreeTask", menuName = "SearchBinaryTreeTask")]
    public class SearchBinaryTreeTask : Task {
        public override void Execute() {

            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();

            Employee[] arrayOutput = BinaryTree.EmployeesWithinDateTimeRange(
                new DateTime(2234, 08, 07, 20, 44, 44),
                new DateTime(2234, 04, 07, 20, 44, 44));

            stopwatch.Stop();

            foreach(Employee e in arrayOutput) {
                e.Initialise();
                UnityEngine.Debug.Log(e.name);
                UnityEngine.Debug.Log(e.lastExitFromEngineRoomDateTime);
            }

            UnityEngine.Debug.Log(arrayOutput.Length);

            UnityEngine.Debug.Log(stopwatch.ElapsedTicks);

        }
    }
}
