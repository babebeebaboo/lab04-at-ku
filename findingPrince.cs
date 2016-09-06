/////////////////////////////////////////////
//NAME: Supakorn Wongsawang                  
//ID: 5910500147                             
//PROGRAM: findingPrince.cs                  
//DATE: 1 Sep 2016                           
/////////////////////////////////////////////

using System;
class test
{
	static void Main()
	{
		int no=0,yes=0,que=0;
		Console.WriteLine("Qualifications:");
		Console.Write("looks: ");
		int a = (Console.Read());
		if(a == 'y')yes++;
		else if(a=='n')no++;
		else if(a=='?')que++;
		Console.Write("financial status: ");
		a = Console.Read();
		if(a == 'y')yes++;
		else if(a=='n')no++;
		else if(a=='?')que++;
		Console.Write("fighting skill: ");
		a = Console.Read();
		if(a == 'y')yes++;
		else if(a=='n')no++;
		else if(a=='?')que++;
		Console.Write("intelligence: ");
		a = Console.Read();
		if(a == 'y')yes++;
		else if(a=='n')no++;
		else if(a=='?')que++;
		Console.Write("communication skill: ");
		a = Console.Read();
		if(a == 'y')yes++;
		else if(a=='n')no++;
		else if(a=='?')que++;
		Console.Write("charisma: ");
		a = Console.Read();
		if(a == 'y')yes++;
		else if(a=='n')no++;
		else if(a=='?')que++;
		Console.Write("sacrifice: ");
		a = Console.Read();
		if(a == 'y')yes++;
		else if(a=='n')no++;
		else if(a=='?')que++;
		
		if(que>3)Console.WriteLine("Not passed : Too much unknown qualifications");
		else if(yes>no)Console.WriteLine("Passed");
		else Console.WriteLine("Not Passed");
	}
}
