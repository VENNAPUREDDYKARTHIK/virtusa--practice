using System;
/
class A{
    public void Kar(){    
        Console.WriteLine("not overrided A");
    }

    public void kar(string s,int y){
        Console.WriteLine(s+" "+y);
    }

}


class sai{
    public static void Main(string[] args){
        A o=new A();
        o.kar();
        o.kar("kar",6);

    }
}