
/*
using System;
					
public class Program
{
	public static void Main()
	{
		Program p  = new Program();
		Console.WriteLine(p.Paragraph("World"));
	}
	////////////////////////////////
	 //function enum months
	public int Months(enum.month){
		enum Month {Januari = 31, Februari = 30, Mars = 31, April = 30, Maj = 31, Juni = 30,
					Juli = 31, Augusti = 30, September = 31, October = 30, November = 31, December = 30,}
		return 
	}
	
	//function 6 returnera "<p>string</p>"
	public string Paragraph(string a){
		return("<p>"+a+"</p>");
	}
	
	//function 5 avrunda ett tal till två decimaler
	public double Avrunda(double num){
		return Math.Round(num,2);
		//int placeHolder = num;
		//double placeHolder2 = placeHolder - num;
		//example
		//3.45	3 and 0.45 
		//
	}
	
	//function 4 Välkommen
	public void Välkommen(string name, string stad, ushort num){
		//Console.WriteLine($"Välkommen {name} från {stad} med favorittal {num}");
		Console.WriteLine("Välkommen {0} från {1} med favorittal {2}", name, stad, num);
	}
	
	//fucntion 3 using multi and add
	public double Func3(double a, double b, double c, double d){
		//double x = Multi(a, b, c);
		//return(Add(x,d));
		return(Add(Multi(a, b, c), d));
	}
	
	//function 2 multi STATIC
	public static double Multi(double a, double b, double c){
		return a * b * c;
	}
	
	//Function 1 Add
	public double Add(double a, double b){
		return a+b;
	}
	
}
*
public static void Main()
	{
		Console.WriteLine("---Welcome to Move @!---");
		char[,] array2D = new char[,] 
		{{'#','#','#','#','#','#','#','#'},
		 {'#','-','-','-','-','-','-','#'},
		 {'#','-','-','-','@','-','-','#'},	//2,4
		 {'#','-','-','-','-','-','-','#'},
		 {'#','#','#','#','#','#','#','#'}};
		
		char userInput;
		bool endGame = false;
		int a = 2, b = 4; 	//these will remember where @ is
		while(endGame == false){
			//print screen
			Console.Clear();
			Console.WriteLine("Use w,a,s,d and enter to move\n");
			for(int x = 0; x < 5; x++){
				for(int y = 0; y < 8; y++){
					Console.Write(array2D[x,y]);
				}
				Console.WriteLine();
			}
			
			//constrols
			userInput = char.Parse(Console.ReadLine());
			if(userInput == 'w'){array2D[a,b] = '-'; array2D[a-1, b] = '@'; a--;}
			else if(userInput == 's'){array2D[a,b] = '-'; array2D[a+1, b] = '@'; a++;}
			else if(userInput == 'a'){array2D[a,b] = '-'; array2D[a, b-1] = '@'; b--;}
			else if(userInput == 'd'){array2D[a,b] = '-'; array2D[a, b+1] = '@'; b++;}
			else if(userInput == 'q'){Console.WriteLine("ending game"); endGame = true;}
			else{Console.WriteLine("Error. Wrong input"); endGame = true;}
		}
		Console.WriteLine("\nGood Bye!");
	}
  */
