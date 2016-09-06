/////////////////////////////////////////////
//NAME: Supakorn Wongsawang                  
//ID: 5910500147                             
//PROGRAM: chromosome.cs                     
//DATE: 2 Sep 2016                           
/////////////////////////////////////////////
using System;

class test
{
   static void inp(out string sex,out string dis)
   {
      Console.Write("Choose sex [Male,Female] : ");
      sex = Console.ReadLine();
      Console.Write("Choose disease [Cri,Pat,Edw,Dow,Tur,Kli,Triplex,Oth,No] : ");
      dis = Console.ReadLine();
      
   }
   static void Main()
   {
      string sex,dis; 
      inp(out sex,out dis); 
      
      if(dis.ToLower() == "dow")
	 printch(21,"add",ref sex);
     
      if(dis.ToLower()=="cri")
	 printch(5,"del",ref sex);
      
      if(dis.ToLower() == "edw")
	 printch(18,"add",ref sex);
      
      if(dis.ToLower() == "pat")
	 printch(13,"add",ref sex);

      if(dis.ToLower() == "no")
	 printch(0,"add",ref sex);
      
      if(dis.ToLower() == "tur")
	 if(sex.ToLower() =="female")
	    printch(23,"del",ref sex);
      
      if(dis.ToLower() == "kli")
	 if(sex.ToLower() =="male")
	    printch(23,"add",ref sex);
      
      if(dis.ToLower() == "triplex")
	 if(sex.ToLower() =="female")
	    printch(23,"add",ref sex);
    
      if(dis.ToLower() == "oth")
      {
	 Console.Write("Choose Chromosome [1-22,X,Y] : ");
	 string chro = Console.ReadLine();
	 Console.Write("Choose Add or Delete[+,-] : ");
	 string choose = Console.ReadLine();
	 if(chro == "x" || chro=="y")
	    printch(chro,choose);
	 else 
	    printch(Convert.ToInt32(chro),choose,sex);

      }
   }
   static void printch(int tua,string what,ref string sex)
   {
      for(int i=1;i<=22;i++)
      {
	 if(tua==i)
	 {
	    if(what =="add")
	       Console.Write("AAA");
	    else 
	       Console.Write("A");
	 }
	 else Console.Write("AA");
	 Console.Write(" ");
	 if(i%5==0)Console.WriteLine();
      }
      if(tua == 23)
      {
	 if(sex == "female")
	 {
	    if(what == "add")
	       Console.Write("XXX");
	    else 
	       Console.Write("Y");
	 }
	 else
	 {
	    if(what == "add")
	       Console.Write("XXY");
	    else 
	       Console.Write("X");
	 }
      }
      else 
      {
	 if(sex == "female")
	    Console.Write("XX");
	 else 
	    Console.Write("XY");
      }

   }
   static void printch(int chro,string choose,string sex)
   {
      int aaaa;
      for(int i=1;i<=22;i++)
      {
	 if( chro == i )
	 {
	    if(choose == "-")
	       Console.Write("A");
	    else 
	       Console.Write("AAA");
	 }
	 else
	    Console.Write("AA");
	 Console.Write(" "); 
	 if(i%5==0)
	    Console.WriteLine();
      }
	 if(sex == "female")
	    Console.Write("XX");
	 else 
	    Console.Write("XY");
      }
   
   static void printch(string chro,string choose)
   {
      for(int i=1;i<=22;i++)
      {
	 Console.Write("AA");
	 Console.Write(" ");
	 if(i%5==0)Console.WriteLine();
      }
      if(chro == "x")
      {
	 if(choose == "-")
	    Console.Write("Y");
	 else 
	    Console.Write("XXY");
      }
      if(chro == "y")
      {
	 if(choose == "-")
	    Console.Write("X");
	 else 
	    Console.Write("XYY");
      }
   }
}
