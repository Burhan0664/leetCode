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
    public bool IsBalanced(TreeNode root)
    {
        return Depth(root) != -1;
    }
    private int Depth(TreeNode node)
    {
        if (node == null) return 0;

        int left = Depth(node.left);
        if (left == -1) return -1;

        int right = Depth(node.right);
        if (right == -1) return -1;

        if (Math.Abs(right - left) > 1) return -1;

        return Math.Max(left, right) + 1;

    }

    // Second Algorithm
    public bool IsBalanced(TreeNode root)
    {
        if (root == null) return true;

        int left = Depth(root.left);    
        int right = Depth(root.right);

        return Math.Abs(left- right) <= 1 && Depth(root.left) && Depth(root.right);   
    }

    private int Depth(TreeNode node)
    {
        if (node == null) return 0;
        return Math.Max(Depth(node.left), Depth(node.right)) + 1;
    }

}

