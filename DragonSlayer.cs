/////////////////////////////////////////////
//NAME: Supakorn Wongsawang                  
//ID: 5910500147                             
//PROGRAM: DragonSlayer.cs                   
//DATE: 1 Sep 2016                           
/////////////////////////////////////////////
using System;

class test
{
	static void Main()
	{
		int exp=0;
		int db=1;
		int timedragon=0;
		while(true)
		{	
			Console.Write("Action Kill or Use : ");
			string a = Console.ReadLine();
			if(a=="kill")
			{
				Console.Write("Kill: ");
				string b = Console.ReadLine();
				if(b == "slime")
				{
					exp +=1*db;	
					Console.WriteLine("Exp +{0}",1*db);
				}
				else if(b=="graywolf")
				{
					exp +=15*db;	
					Console.WriteLine("Exp +{0}",15*db);
				}
				else if(b=="browngorilla")
				{
					exp+=20*db;
					Console.WriteLine("Exp +{0}",20*db);
				}
				else if(b=="forestkeeper")
				{
					exp+=20*db;
					Console.WriteLine("Exp +{0}",20*db);
				}
				else if(b=="unknownenemy")
				{
					exp+=5*db;
					Console.WriteLine("Exp +{0}",5*db);
				}
				else if(b=="dragon")
				{
					timedragon+=1;
					if(exp>=100)
					{	
						Console.WriteLine("Congratulation revenge success, You did it!");
						break;
					}
					else 
					{
						if(timedragon ==2)
						{
							Console.WriteLine("Oh no! You lose and die.");
							break;
						}
						else 
						{
							Console.WriteLine("Oh no! You lose , but you still have 1 chance.");
						}
					}
				}
			}
			else if(a=="use")
			{
				Console.Write("Use : ");
				string b = Console.ReadLine();
				if(b=="double-exp")
				{
					db*=2;
					Console.WriteLine("Use-Exp*2");
				}
			}
		}
	}
}
