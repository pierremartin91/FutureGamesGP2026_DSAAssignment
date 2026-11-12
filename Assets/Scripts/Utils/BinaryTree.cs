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
            data = EmployeeManager.Instance.Employees[400]
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

    public static Employee[] EmployeesWithinDateTimeRange(DateTime lowerRange, DateTime upperRange) {
        // CURRENTLY DOES NOT WORK

        GenericQueue<TreeNode> queue = new GenericQueue<TreeNode>();

        TreeNode current = top;
        bool finished = false;

        while(current != null) {

            if(current.data.lastExitFromEngineRoomDateTime > lowerRange) {
                queue.Enqueue(current);
                if(current.left != null) {
                    current = current.left;

                }
                continue;
            }
            if(current.data.lastExitFromEngineRoomDateTime <= upperRange) {
                queue.Enqueue(current);
                if(current.right != null) {
                    current = current.right;

                }
                continue;
            } else
            current = null;
        }

        Employee[] searchedArray = new Employee[queue.queue.Count];

        for(int i = 0; i <= queue.queue.Count - 1; i++) {
            searchedArray[i++] = queue.Dequeue().data;
        }

        return searchedArray;
    }
}
