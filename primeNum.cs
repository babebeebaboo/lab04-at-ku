/////////////////////////////////////////////
//NAME: Supakorn Wongsawang                  
//ID: 5910500147                             
//PROGRAM: primeNum.cs                       
//DATE: 1 Sep 2016                           
/////////////////////////////////////////////
using System;

class test
{
	private static void Main()
	{
		Console.Write("Input maximum number: ");
		double aa =double.Parse( Console.ReadLine() );
		int number = (int)aa;
		Console.Write("These are prime number:");
		for(int i=2;i<=number;i++)
		{
			bool check=true;
			for(int j=i-1;j>=3;j--)
				if(i%j==0)
					check =false;	
			if(check==true)Console.Write(" {0}",i);
		}
	}
}
