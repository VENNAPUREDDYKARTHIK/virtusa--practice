//union of two arrays
using System;
 
public class karthik
{
    public static void Main(string[] args)
    {
        int a = Convert.ToInt32(Console.ReadLine());
        string rts=Console.ReadLine();
        string[] str=rts.Split(" ");
        int[] arr=new int[a];
        for(int i=0;i<a;i++)
        {
            arr[i]=Convert.ToInt32(str[i]);
        }
        int b = Convert.ToInt32(Console.ReadLine());
        string rts2=Console.ReadLine();
        string[] str2=rts.Split(" ");
        int[] brr=new int[b];
        for(int i=0;i<b;i++)
        {
            brr[i]=Convert.ToInt32(str2[i]);
        }
        int[] crr=new int[a+b];
        for(int i=0;i<a;i++)
        {
            crr[i]=arr[i];
        }
        for(int k=0,l=a;k<b;l++,k++)
        {
            crr[l]=brr[k];
 
        }
        Array.Sort(crr);
        for(int h=0;h<a+b;h++)
        {
            bool flag=false;
            for(int y=0;y<h;y++)
            {
                if(crr[y]==crr[h])
                {
                    flag = true;
                }
            }
            if(flag==false)
            {
                Console.Write(crr[h]+" ");
            }
        }
    }
}