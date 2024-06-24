namespace Assignment_8._2
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }

        //Compare if binary tree is symetrical.
        public bool IsSymmetric(TreeNode root)
        {
            if (root == null) return true;
            Queue<TreeNode> ql = new();
            Queue<TreeNode> qr = new();
            if (root.left != null)
            {
                ql.Enqueue(root.left);
            }
            if (root.right != null)
            {
                qr.Enqueue(root.right);
            }
            while (ql.Count > 0 && qr.Count > 0)
            {
                TreeNode l = ql.Dequeue();
                TreeNode r = qr.Dequeue();
                if (l.val != r.val)
                {
                    return false;
                }
                if (l.left != null && r.right != null)
                {
                    ql.Enqueue(l.left);
                    qr.Enqueue(r.right);
                }
                else if (l.left == null ^ r.right == null) return false;

                if (l.right != null && r.left != null)
                {
                    ql.Enqueue(l.right);
                    qr.Enqueue(r.left);
                }
                else if (l.right == null ^ r.left == null) return false;


            }
            if (ql.Count != 0) return false;
            if (qr.Count != 0) return false;
            return true;
        }
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
        
    }
}
    }
}
