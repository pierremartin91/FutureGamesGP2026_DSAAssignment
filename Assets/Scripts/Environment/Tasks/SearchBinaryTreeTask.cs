using System;
using System.Diagnostics;
using UnityEngine;
using Utils;


namespace Environment.Tasks {
    [CreateAssetMenu(fileName = "SearchBinaryTreeTask", menuName = "SearchBinaryTreeTask")]
    public class SearchBinaryTreeTask : Task {
        public override void Execute() {

            UnityEngine.Debug.Log("BEGGINING SEARCH BINARY TREE TASK");

            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();

            Employee[] arrayOutput = BinaryTree.EmployeesWithinDateTimeRange(
                new DateTime(2234, 8, 9, 22, 00, 00),
                new DateTime(2234, 8, 9, 23, 00, 00));

            stopwatch.Stop();

            UnityEngine.Debug.Log(arrayOutput.Length);

            for (int i = 0; i < arrayOutput.Length; i++) {
                UnityEngine.Debug.Log(arrayOutput[i].name + ":");
                UnityEngine.Debug.Log("Last Entrance: " + arrayOutput[i].lastEntranceInEngineRoomDateTime);
                UnityEngine.Debug.Log("Last Exit: " + arrayOutput[i].lastExitFromEngineRoomDateTime);
            }

            UnityEngine.Debug.Log(arrayOutput.Length);

            UnityEngine.Debug.Log(stopwatch.ElapsedTicks);

        }
    }
}
