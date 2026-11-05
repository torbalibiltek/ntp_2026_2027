/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/

using System;
using System.Linq;
class HelloWorld {
  static void Main() {
    int[] puanlar = new int[3];
    for(int i= 0; i< puanlar.Length; i++)
    {
        Console.WriteLine($"{i+1}. puanı giriniz");
        int puan = Convert.ToInt16(Console.ReadLine());
        puanlar[i] = puan;
    }
        for(int i= 0; i< puanlar.Length; i++)
    {
    
        Console.WriteLine(puanlar[i]);
        
    }
    Array.Sort(puanlar);
            for(int i= 0; i< puanlar.Length; i++)
    {
    
        Console.WriteLine(puanlar[i]);
        
    }
    Console.WriteLine(puanlar.Max());  // returns the largest value
      Console.WriteLine(puanlar.Min());  // returns the smallest value
      Console.WriteLine(puanlar.Sum());  // returns the sum of elements
    
  }
}
