namespace LeetcodeProgrammingProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            TreeNode? leftLeaf = new TreeNode(3, null, null);
            TreeNode? rightLeaf = new TreeNode(4, null, null);
            TreeNode? left = new TreeNode(2, leftLeaf, rightLeaf);
            TreeNode? rightRightLeaf = new TreeNode(6, null, null);
            TreeNode? right = new TreeNode(5, null, rightRightLeaf);
            TreeNode? root = new TreeNode(1, left, right);

            SolutionBinaryTree solution = new SolutionBinaryTree();
            solution.Flatten(root);
            Console.WriteLine(root);
        }
    }
}