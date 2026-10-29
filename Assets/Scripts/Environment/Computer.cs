    using Environment.Tasks;
using System;
using System.Collections.Generic;
using UnityEngine;
using Utils;

namespace Environment {
    [Serializable]
    public class Computer : MonoBehaviour, IInteractable {

        [SerializeField] private GenericQueue<Task> testTasks = new GenericQueue<Task>();

        public void OnInteract() {
            testTasks.Dequeue().Execute();
        }
    }
}
