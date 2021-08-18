
/*
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
