using System;
using System.Linq;
class HelloWorld {
  static void Main() {
    Console.WriteLine();
    int n=Convert.ToInt32(Console.ReadLine());
    int[] a=new int[n];
    int j=10;
    for(int i=0;i<n;i++){
        a[i]=j;
        j-=2;
    }
    for(int i=0;i<a.Length;i++){
        Console.Write(a[i]+" ");
    }
    Array.Sort(a);
    for(int i=0;i<a.Length;i++){
        Console.Write(a[i]+" ");
    }
    foreach(int i in a){
        Console.WriteLine(i);
    }
    //Linq
    Console.WriteLine(a.Min());
    Console.WriteLine(a.Max());
    Console.WriteLine(a.Sum());
  }
}