//Another solution

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
public class Solution
{
    public int MaxDepth(TreeNode root)
    {
        if (root == null) return 0;
        return Visit(root);
    }

    public int Visit(TreeNode n)
    {
        if (n == null) return 0;
        return Math.Max(Visit(n.left), Visit(n.right)) + 1;
    }
}