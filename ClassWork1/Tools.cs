//////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Project:		Classwork1
//	File Name:		Tools.cs
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
using System.Windows.Forms;

namespace ClassWork1
{
	public static class Tools
	{
		/// <summary>
		/// Tokenizes the specified line.
		/// </summary>
		/// <param name="line">The line.</param>
		/// <param name="delims">The delims.</param>
		/// <returns>Tokenized array of strings from input</returns>
		public static String [ ] Tokenize (string line, string delims)
		{

			List<string> listTokens = new List<string> ( );	//List of tokens
			int Position = 0;								//Position of tokens
			string tempToken;                               //Temporary Sub-String Holder
			//While line if not empty
			while (line.Length != 0)
			{
				//Remove leading whitespace
				if (line.StartsWith (" "))
				{
					line = line.TrimStart (' ');
				}//End if statement
				Position = line.IndexOfAny (delims.ToCharArray ( ));
				//Check if line is empty
				if (Position == -1)
				{
					break;
				}
				//Check string position is whitespace
				if (line [Position].Equals (' '))
				{
					
					tempToken = line.Substring (0, Position);
					//Remove section of string  
					line = line.Remove (0, tempToken.Length);
					//Remove leading whitespaces
					line = line.TrimStart (' ');
					//Add token to list
					listTokens.Add (tempToken);
				}//End if statement
				//Check if delimiter is in the starting position
				else if (Position == 0)
				{
					//Add delimiter to list
					listTokens.Add (line [0].ToString ( ));
					line = line.Remove (0, 1);
				}//End else if statement
				 //Delimitor in the middle of words
				else
				{
					tempToken = line.Substring (0, Position);
					//Add both tokens to list
					listTokens.Add (tempToken);
					listTokens.Add (line[Position].ToString());
					//Remove section of string plus next delimiter
					line = line.Remove (0, tempToken.Length+1);
				}//End else statement
			}//End while loop			
			return listTokens.ToArray();
		}//End Tokenize ( )
		 /// <summary>
		 /// Presses any key.
		 /// </summary>
		public static void PressAnyKey ( )
		{
			Console.WriteLine ("Press a key to continue");
			Console.ReadLine ( );
		}//End PressAnyKey ( )
		 /// <summary>
		 /// Welcomes the message.
		 /// </summary>
		 /// <param name="info">The information.</param>
		 /// <param name="title">The title.</param>
		public static void WelcomeMessage (string info, string title)
		{
			MessageBox.Show (info, title);
		}//End WelcomeMessage ( )
		 /// <summary>
		 /// Goodbyes the message.
		 /// </summary>
		 /// <param name="info">The information.</param>
		 /// <param name="title">The title.</param>
		public static void GoodbyeMessage (string info, string title)
		{
			MessageBox.Show (info, title);
		}//End GoodbyeMessage ( )

		/*
		/// <summary>
		/// Tokenizes the specified line. Using split to delete whitespaces.
		/// </summary>
		/// <param name="line">The line.</param>
		/// <param name="delims">The delims.</param>
		/// <returns></returns>
		public static String [ ] Tokenize (string line, string delims)
		{
			string [ ] tokens;
			int tempStart = 0;
			int Position = 0;
			bool breakOut = false;
			while (breakOut == false)
			{
				Position = line.IndexOfAny (delims.ToCharArray ( ), tempStart + 1);
				if (Position == line.Length - 1 && Position >= 0)
				{
					breakOut = true;
				}//End if statement
				else
				{
					if (!line [Position - 1].Equals (' ') && !line [Position + 1].Equals (' '))
					{
						string subLeft = line.Substring (0, Position);
						string subRight = line.Substring (Position + 1);
						line = subLeft + " " + line [Position] + " " + subRight;
						continue;

					}//End if statement
					if (!line [Position - 1].Equals (' ') && line [Position + 1].Equals (' '))
					{
						string subLeft = line.Substring (0, Position);
						line = subLeft + " " + line [Position] + line.Substring (Position + 1);
						continue;
					}//End if statement
					if (line [Position - 1].Equals (' ') && !line [Position + 1].Equals (' '))
					{
						string subLeft = line.Substring (0, Position);
						string subRight = line.Substring (Position + 1);
						line = subLeft + line [Position] + " " + subRight;
						continue;
					}//End if statement
					tempStart = line.IndexOfAny (delims.ToCharArray ( ), Position);
				}//End else statement
			}//End while loop
			tokens = line.Split (' ');
			return tokens;
		}//End Tokenize ( )*/
	}//End class Tools
}//End Tools
