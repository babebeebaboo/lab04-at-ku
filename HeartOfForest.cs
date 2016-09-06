/////////////////////////////////////////////
//NAME: Supakorn Wongsawang                  
//ID: 5910500147                             
//PROGRAM: HeartOfForest.cs                  
//DATE: 1 Sep 2016                           
/////////////////////////////////////////////
using System;
class test
{
	static void Main()
	{
		int all=0;
		int poultry=0;
		int aquatic=0;
		int amphibian=0;
		int reptile=0;
		int mammal=0;
		string a= "";
		while(true)
		{
			a = Console.ReadLine();
			if(a=="owl")poultry++;
			if(a=="eel")aquatic++;
			if(a=="salamander")amphibian++;
			if(a=="cobra")reptile++;
			if(a=="squirrel")mammal++;
			if(a=="jaguar")mammal++;
			if(a=="alligator")reptile++;
			if(a=="loris")mammal++;
			if(a=="dove")poultry++;
			if(a=="mackerel")aquatic++;
			if(a=="bullfrog")amphibian++;
			if(a=="end")break;
		}
		if(poultry>=1)
			if(aquatic>=1)
				if(amphibian>=1)
					if(reptile>=1)
						if(mammal>=1)
						{
							Console.WriteLine("Heart of forest : Yes");
							all=1;
						}
		if(all==0)
			Console.WriteLine("Heart of forest : No");
		Console.WriteLine("Real animals : {0}",poultry+aquatic+amphibian+reptile+mammal);
		Console.WriteLine("Poultry : {0}",poultry);
		Console.WriteLine("Aquatic : {0}",aquatic);
		Console.WriteLine("Amphibian : {0}",amphibian);
		Console.WriteLine("Reptile : {0}",reptile);
		Console.WriteLine("Mammal : {0}",mammal);
	}
}
