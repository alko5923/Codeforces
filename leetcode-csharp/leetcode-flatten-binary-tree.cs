/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class SolutionBinaryTree {
    public TreeNode previousRoot = null;
    public void Flatten(TreeNode root) {
        if (root == null)
        {
            return;
        }
        // Reverse pre-order traversal
        Flatten(root.right);
        Flatten(root.left);
        root.right = previousRoot;
        root.left = null;
        previousRoot = root;
    }
}