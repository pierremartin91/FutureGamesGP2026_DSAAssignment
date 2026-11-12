using Environment.Tasks;
using UnityEngine;

[CreateAssetMenu(fileName = "PopulateTask", menuName = "Scriptable Objects/PopulateTask")]
public class PopulateTree : Task {
    public override void Execute() {
        BinaryTree.PopulateTree();

        BinaryTree.TraverseTree();
    }
}
