// A binary tree implementation with the methods to add a node,
// remove a node, find a node, get the depth of the tree, 
// pre-order, in-order and post-order traversal. 
public class TreeNode {
      public int val;
      public TreeNode? left;
      public TreeNode? right;
      public TreeNode(int val=0, TreeNode? left=null, TreeNode? right=null) {
          this.val = val;
          this.left = left;
          this.right = right;
      }

    public override string ToString()
    {
        return base.ToString() + ":" + val.ToString() + (left==null ? " left -> null " : " left -> " + left.ToString())
                                + (right==null ? " right -> null " : " right -> " + right.ToString());
    }
}