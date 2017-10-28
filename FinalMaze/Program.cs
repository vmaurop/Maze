using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalMaze
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;                                     //ForegroundColor(style console write green color)
            Console.Write("Starting point:100\nExit:-7\nopen route:0\nclosed route:-1\n\n\n");//informations for the maze...
            Console.ResetColor();//reset to default


            try
            {
                string maze = System.IO.File.ReadAllText(@"MAZE5.txt"); //read file MAZE1.txt and assign to string maze
                Functions x = new Functions();                       //create an object of class Functions
                var Mazearray = x.GetMaze(maze);                     //get maze 
                x.Print(Mazearray);                                  //print maze
                x.Solve(Mazearray);                                  //solve maze
                Console.ReadLine();                                  //wait for enter..
            }
            catch(System.IO.IOException)                             //catch exceptions from file...
            {
                Console.WriteLine("can not read the file");
                Console.ReadLine();
            }

        }
    }
}
