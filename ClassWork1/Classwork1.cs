//////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Project:		Classwork1
//	File Name:		Classwork1.cs
//	Description:	Demonstrate the Tokenize method by inputting a string	
//	Course:			CSCI 2210-001 - Data Structures
//	Author:			Justin Adams, adamsjl3@etsu.edu, Undergrade CS, East Tennessee State University
//	Created:		Thursday, September 07, 2017
//	Copyright:		Justin Adams, 2017
//
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork1
{
	class Classwork1
	{
		static void Main (string [ ] args)
		{
			string sentenceHolder = null;				//Hold keyboard inputted data from user
			bool validsentence = false;					//Check if user enter correct data
			string [ ] tokens = new string [ ] { } ;    //Holder of parse user data
			string welcomeMessage = "Welcome, this program will show all tokens in a inputted message";
			string goodbyeMessage = "Thank you, for using this program if you have any question.\n" +
									"\nPlease contect me at:\n\n" +
									"Justin Adams\n" +
									"Adamsjl3@etsu.edu\n" +
									"CSCI 2210\n";

			Tools.WelcomeMessage (welcomeMessage,"Classwork1");
			Console.BackgroundColor = ConsoleColor.White;
			Console.ForegroundColor = ConsoleColor.Blue;
			Console.Clear ( );

			//Debugger String
			/*
			sentenceHolder = " That is strange. When for example writing int[] variable = " +
			"new int[]{} and using it for example in a loop such as foreach (var s in variable)" +
			"{ Console.WriteLine(s);} the code is compiled to: int[] args1 = new int[0]; and " +
			"foreach (int num in args1){Console.WriteLine(num);}. So there should be no difference " +
			"between using new int[0] and new int[]{} as both get compiled to the same code. ";
			*/
			do
			{
				Console.WriteLine ("Please enter a sentence");
				sentenceHolder = Console.ReadLine ( );
				if (sentenceHolder.Equals (null)|| sentenceHolder.Equals (""))
				{
					Console.WriteLine ("Invalid, please enter a sentence");
				}//End if statement
				else
				{
					tokens = Tools.Tokenize (sentenceHolder, @" \'.,-()=-+*/!?%&[]{}");
					validsentence = true;
				}//End else statement
			} while (validsentence == false);//End do-while loop
			
			for (int i = 1 ; i < tokens.Length+1 ; i++)
			{
				Console.WriteLine (i+". "+tokens [i-1]);
				if (i % 20 == 0)
				{
					Tools.PressAnyKey ( );
				}//End if statement
			}//end for loop
			Tools.WelcomeMessage (goodbyeMessage, "Classwork1");
		}//End Main (String [])
	}//End class ClassWork1
}//End ClassWork1
