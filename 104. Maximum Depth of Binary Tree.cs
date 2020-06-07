//First Solution

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
        var node = new Queue<TreeNode>();
        var num = new Queue<int>();
        var res = 1;

        var count = 0;
        if (root == null)
        {
            res = 0;
        }
        else
        {
            if (root.left != null)
            {
                node.Enqueue(root.left);
                num.Enqueue(2);
            }

            if (root.right != null)
            {
                node.Enqueue(root.right);
                num.Enqueue(2);
            }

            while (node.Count > 0)
            {
                var x = node.Dequeue();
                res= num.Dequeue();

                if (x.left != null)
                {
                    node.Enqueue(x.left);
                    num.Enqueue(res+1);
                }

                if (x.right != null)
                {
                    node.Enqueue(x.right);
                    num.Enqueue(res+1);
                }
            }
        }

        return res;
    }
}