/////////////////////////////////////////////
//NAME: Supakorn Wongsawang                  
//ID: 5910500147                             
//PROGRAM: tryParse.cs                       
//DATE: 2 Sep 2016                           
/////////////////////////////////////////////
using System;
class test
{
   static void Main()
   {
      int number;
      double dou;
      char ch;
      byte by;
      Console.Write("Input string: ");
      string str = Console.ReadLine();
      int.TryParse(str,out number);
      if(int.TryParse(str,out number))
	 Console.WriteLine("{0} can convert to integer.",str);
      else 
	 Console.WriteLine("{0} cannot convert to integer.",str);

      if(double.TryParse(str,out dou))
	 Console.WriteLine("{0} can convert to double.",str);
      else 
	 Console.WriteLine("{0} cannot convert to double.",str);

      if(char.TryParse(str,out ch))
	 Console.WriteLine("{0} can convert to character.",str);
      else 
	 Console.WriteLine("{0} cannot convert to character.",str);

      if(byte.TryParse(str,out by))
	 Console.WriteLine("{0} can convert to byte.",str);
      else 
	 Console.WriteLine("{0} cannot convert to byte.",str);

   }
}

