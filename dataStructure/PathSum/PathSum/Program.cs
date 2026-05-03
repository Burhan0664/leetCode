
using System.Reflection.Metadata.Ecma335;
using System.Security.AccessControl;

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
    int sum = 0;
    public bool HasPathSum(TreeNode root, int targetSum)
    {
        return FindSum(root, targetSum, sum);
        return FindSecondPath(root, targetSum);
    }
    private bool FindSum(TreeNode root,int targetSum ,int sum)
    {
        if (root == null) return false;
        sum += root.val;
        if (root.left == null && root.right == null)
        {
            return sum == targetSum;
        }
        return FindSum(root.right, targetSum, sum) || FindSum(root.left, targetSum, sum);
    }

    private bool FindSecondPath(TreeNode root,int targetSum)
    {
        if (root == null) return false;

        targetSum -= root.val;
        if (root.left == null && root.right == null)
        {
            return targetSum == 0;
        }

        return FindSecondPath(root.right, targetSum) || FindSecondPath(root.left, targetSum);

    }
}