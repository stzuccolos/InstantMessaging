using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeTraversal;

public class TreeNode(int payload, List<TreeNode> children)
{
    public int Payload { get; set; } = payload;
    public List<TreeNode> Children { get; set; } = children;

    public IEnumerable<TreeNode> GetLeaves()
    {
        var leaves = new List<TreeNode>();
        GetLeaves(this, leaves);
        return leaves;
    }


    private void GetLeaves(TreeNode root, List<TreeNode> leaves)
    {
        if (!root.Children.Any())
        {
            leaves.Add(root);
            return;
        }

        foreach (TreeNode child in root.Children)
        {
            GetLeaves(child, leaves);
        }
    }
}

