namespace part4
{
  using System;

public class Order
{
    int[] preOrder;
    int[] inOrder;
    int[] result;
    int[] NodeLocationInOrder;

    public Order() {}

    public int[] Create(int[] a, int[] b) 
    {
        this.preOrder = a;
        this.inOrder = b;
        int n = preOrder.Length;
        result = new int[n];

        NodeLocationInOrder = new int[n + 1];
        for (int i = 0; i < n; i++) 
        {
            NodeLocationInOrder[inOrder[i]] = i;
        }
        FormPostOrder(0, n - 1, n, n - 1, n, n - 1);
        return result;
    }

    public void FormPostOrder(int pOFirst, int pOLast, int iOFirst, int iOLast, int poOFirst, int poOLast)
    {
        if (pOFirst > pOLast) return;
        int root = preOrder[pOFirst];
        result[pOLast] = root;
        int location = NodeLocationInOrder[root];
        int amount = location - iOFirst;
        FormPostOrder(pOFirst + 1, pOFirst + 1 + amount - 1, iOFirst, iOFirst + amount - 1, poOFirst, poOFirst + amount - 1);
        FormPostOrder(pOFirst + 1 + amount, pOLast, location + 1, iOLast, poOFirst + amount, poOLast - 1);
    }     
}

public class TreeNode
{
    private int value;
    public TreeNode leftChild;

    public TreeNode rightChild;

    public TreeNode(int value)
    {
        this.value = value;
        this.leftChild = null;
        this.rightChild = null;
    }

    public void AddChild(int value)
    {
        if (value < this.value)
        {
            if (this.leftChild == null) 
            {
                this.leftChild = new TreeNode(value);
            }
            else
            {
                this.leftChild.AddChild(value);
            }
        }
        else if (value > this.value)
        {
            if (this.rightChild == null)
            {
                this.rightChild = new TreeNode(value);
            }
            else
            {
                this.rightChild.AddChild(value);
            }
        }
      }  
    }
}
 