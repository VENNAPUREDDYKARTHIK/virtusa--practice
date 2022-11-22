using System;
public class vir{
public static void Main(){
int n=Convert.ToInt32(Console.ReadLine());
int[] a=new int[n];
for(int i=0;i<n;i++){
a[i]=Convert.ToInt32(Console.ReadLine());
}
bool[] b=new bool[n];
for(int i=0;i<n;i++){
int c=0;
for(int j=0;j<i;j++){
if(a[i]==a[j]){
c+=1;
}
}
if(c<=1){
b[i]=true;
}
else{
b[i]=false;
}
}

for(int i=0;i<n;i++){

}

}
}