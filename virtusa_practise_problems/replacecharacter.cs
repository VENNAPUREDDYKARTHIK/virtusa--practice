//replace character
using System;
class karthik{
public static void Main(){

Console.WriteLine("Enter a string : ");
string str = Console.ReadLine();
char[] ch = str.ToCharArray();
for(int i=0;i<str.Length;i++){
    int a=((int)ch[i]+3);
    if(a==123){
        Console.Write('a');
    }else if(a==124){
        Console.Write('b');
    }
    else if(a==125){
        Console.Write('c');
    }else{
    Console.Write((char)a);
    }
}
}
}