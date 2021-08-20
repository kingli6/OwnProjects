using System;
					
public class Program
{
	public static void Main()
	{
		Program p  = new Program();
		Console.WriteLine(p.DaysinMonth(Month.februari));
	}
	////////////////////////////////
	
	
	public enum Month{
	januari = 1, februari, mars, april, maj, juni, augusti, september, oktober, november, december
	}
	
	 //function enum months
	public int DaysinMonth(Month month){
		if(month == Month.februari)				//notice Month.februari is needed when comparing
			return 28;
		else if((int)month % 2 == 0) return 30;	//notice the (int) while calculating
		else return 31;
		//error
		//Not being able to find a way to return a value that's assigned to the enum.
	}
	
	//function 6 returnera "<p>string</p>"
	public string Paragraph(string a){
		return("<p>"+a+"</p>");
	}
	
	//function 5 avrunda ett tal till två decimaler
	public double Avrunda(double num){
		//return Math.Round(num,2);
		int placeHolder = int.Parse(num);
		double placeHolder2 = placeHolder - num;
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

/**
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
*
Random r = new Random();
		int[] arr = new int[10];
		for(int x = 0; x < arr.Length; x++){
			arr[x] = r.Next(0, 20);
		}
		for(int x = 0; x < arr.Length; x++){
			Console.Write(arr[x] + ", ");
		}
		Console.WriteLine();
		
		int placeHolder = 0;
		for(int i= 0; i < arr.Length; i++){
			for(int y = 0; y < arr.Length; y++){
				if(arr[i] > arr[y]){
					placeHolder = arr[i]; arr[i] = arr[y]; arr[y] = placeHolder;
				}
			}
			
		}
		for(int x = 0; x < arr.Length; x++){
			Console.Write(arr[x] + ", ");
		}
*

**/
