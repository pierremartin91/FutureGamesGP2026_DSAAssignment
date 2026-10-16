    using Environment.Tasks;
using System;
using System.Collections.Generic;
using UnityEngine;
using Utils;

namespace Environment {
    [Serializable]
    public class Computer : MonoBehaviour, IInteractable {

        [SerializeReference] private GenericQueue<Task> testTasks = new GenericQueue<Task>();

        [SerializeField]
        private List<Task> tasks = null; 

        public void Awake() {
            foreach(var task in tasks) {
                testTasks.Enqueue(task);
            }
        }

        public void OnInteract() {
            testTasks.Dequeue().Execute();
        }
    }
}
