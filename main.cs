using System;

class MainClass {
  public static void Main (string[] args) {
    int h,n, total=0;
   Console.WriteLine(" Digite um número final: ");
   n = int.Parse(Console.ReadLine());
   for( h=1; h<=n; h++)
    {
      total = h+total;
    }  
  
     Console.WriteLine("O número final é: {0}", total);
      
  }  
}