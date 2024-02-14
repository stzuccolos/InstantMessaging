namespace TreeTraversal;

internal class Program
{
    static void Main(string[] args)
    {
        var treeRoot = new TreeNode
        (
            1,
            [
                new
                (
                    2,
                    [
                        new (3, []),
                        new (4, [])
                    ]
                ),
                new (5, [])
            ]
        );

        var leaves = treeRoot.GetLeaves();
        foreach (var leave in leaves)
        {
            Console.WriteLine(leave.Payload);
        }

        Console.ReadKey();
    }
}
