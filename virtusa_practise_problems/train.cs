sing System;
class Karthik{
    public static void Main()
    {
        string k=Console.ReadLine();
        int n=Convert.ToInt32(k);
        string str=Console.ReadLine();
        string[] rts=str.Split(" ");
        int[] arr = new int[n];
        for(int i=0;i<n;i++)
        {
            arr[i]=Convert.ToInt32(rts[i]);
        }
        int[] brr = new int[n];
        string str1=Console.ReadLine();
        string[] rts1=str1.Split(" ");
        for(int j=0;j<n;j++)
        {
            brr[j]=Convert.ToInt32(rts1[j]);
        }
      int p=1;
      int res=1;
      for(int i=0;i<n;i++)
      {
        p=1;
        for(int j=0;j<n;j++)
        {
            if(i!=j)
            {
                if(arr[i]>=arr[j] && brr[j]>=brr[i])
                {
                    p=p+1;
                }
            }
        }
        res=Math.Max(p,res);
      }
      Console.WriteLine(res);
    }
}