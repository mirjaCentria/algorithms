namespace part4
{
  using System;
 
  public class Order //with the following method:
  {

    public Order()
    {
      /*
      Pre-order: First handle the root, then the left subtree, then the right subtree
      In-order: First handle the left subtree, then the root, then the right subtree
      Post-order: First handle the left subtree, then the right subtree, then the root*/

      /* root1 =  a[0] 
bleft < root< bright
root = 4
left1 = 2 < 4 < right1 = 1 =root2
left2 = 3 < I = ROOT2 < right  5 
23514
root = a0 >> clast
while left = xb<root 
while right = xb >root
rekursio left >> root2 left2 right2 ..... return left(left right root)
rekursio rigth >>  root left right ... return rigth(left right root)*/
    }

    public int[] Create(int[] a, int[] b)  //, which returns the post-order of the nodes.
    { 
      int i;
      int ll = a.Length;
      int root = a[0];
      
      int[] c = new int[ll]; 
      c[ll] = root; 
      int[] left = new int[ll];
      int[] right = new int[ll];
      
      for(i = 1; i < ll; i++)
      {
        if(b[i] == root) break;
        left[i] = b[i];
      }
      Array.Resize(ref left,ll-i);
      b.CopyTo(right, i +1);

      
      return c;
    }


    public int[] Divide(int )
  }

}
 