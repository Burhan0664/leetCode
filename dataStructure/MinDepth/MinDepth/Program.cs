public class Solution
{
    public int MinDepth(TreeNode root)
    {
        return Find(root);
    }

    private int Find(TreeNode root)
    {
        if (root == null) return 0;

        int left = Find(root.left);
        int right = Find(root.right);

        if (left == 0) return right + 1;
        if (right == 0) return left + 1;

        return Math.Min(left, right) + 1;
    }
}