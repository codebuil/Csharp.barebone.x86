﻿using System;

namespace screens
{
    class Program
    {

		public static int adds(int a,int b){
			return a+b;
		}
        static void Main(string[] args)

        {
           string memory = "10+10={0} \n";
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();
			Console.Write(memory,screens.Program.adds(10,10));
           

            

        }
    }
}
