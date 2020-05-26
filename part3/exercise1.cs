namespace part3
{
  using System;
 
  public class HelloBot
  {
   // public void HelloBot(){}
    public void Hello(int n)
    { 
        if(n == 0) return;
        else 
        {
            System.Console.WriteLine("Hello!");
            this.Hello(n -1);
        }
    }
  }
}
/*void Hello(n)
  if n == 0
    return
  else
    print("Hello!")
    Hello(n-1)*/