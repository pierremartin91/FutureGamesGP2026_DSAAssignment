using System;
using System.Linq;
using UnityEngine;
using Utils;

[Serializable]
public class BinaryTree {
    public static TreeNode top;

    public class TreeNode {
        public Employee data;
        public TreeNode left;
        public TreeNode right;
    }

    public static void Insert(TreeNode node, Employee e) {
        if(node.data == null) {
            node.data = e;
            return;
        }
        else {
            if(e.lastExitFromEngineRoomDateTime <= node.data.lastExitFromEngineRoomDateTime) {
                if(node.left == null)
                    node.left = new TreeNode();
                Insert(node.left, e);
            }
            else {
                if(node.right == null)
                    node.right = new TreeNode();
                Insert(node.right, e);
            }
        }
    }

    public static void PopulateTree() {
        EmployeeManager.Instance.employeeBinaryTree = new BinaryTree();

        top = new TreeNode {
            data = EmployeeManager.Instance.Employees[0]
        };

        foreach(Employee e in EmployeeManager.Instance.Employees) {
            Insert(top, e);
        }
    }

    public static void TraverseTree() {
        GenericQueue<TreeNode> queue = new GenericQueue<TreeNode>();

        queue.Enqueue(top);

        TreeNode current;

        int i = 0;

        while(!queue.IsEmpty()) {
            current = queue.Dequeue();
            Debug.Log(current.data.lastExitFromEngineRoomDateTime);

            if(current.left != null) {
                queue.Enqueue(current.left);
                i++;
            }

            if(current.right != null) {
                queue.Enqueue(current.right);
                i++;
            }
        }

        Debug.Log(i);
    }

    public static void RecursiveEnqueue(TreeNode node, DateTime lowerRange,
        DateTime upperRange, GenericQueue<TreeNode> queue) {
        if(node == null) {
            return;
        }
        if(node.data.lastExitFromEngineRoomDateTime >= lowerRange) {
            RecursiveEnqueue(node.left, lowerRange, upperRange, queue);
        }
        if(node.data.lastExitFromEngineRoomDateTime >= lowerRange &&
            node.data.lastExitFromEngineRoomDateTime <= upperRange) {
            queue.Enqueue(node);
        }
        if(node.data.lastExitFromEngineRoomDateTime <= upperRange) {
            RecursiveEnqueue(node.right, lowerRange, upperRange, queue);
        }
    }

    public static Employee[] EmployeesWithinDateTimeRange(DateTime lowerRange, DateTime upperRange) {
        GenericQueue<TreeNode> queue = new GenericQueue<TreeNode>();

        RecursiveEnqueue(top, lowerRange, upperRange, queue);

        int queueSize = queue.queue.Count;

        Employee[] searchedArray = new Employee[queueSize];

        for(int i = 0; i < queueSize; i++) {
            searchedArray[i] = queue.Dequeue().data;
        }

        return searchedArray;
    }
}
