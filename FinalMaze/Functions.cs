using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FinalMaze
{
    class Functions : IFunctions  //implements of IFunctions...
    {
        int count = 0;//counting moves...instance variable

        public int[][] GetMaze(string maze)
        {
            //this function receives  a string as an argument and return a jagged array with numbers(int)
            string[] lines = maze.Split(new char[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);// Split apart the maze string.

            
            int[][] Mazearray = new int[lines.Length][];             // Create jagged array(arrays into array).
            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i];
               
                var row = new int[line.Length];                         // Create row
                for (int x = 0; x < line.Length; x++)
                {

                    switch (line[x])       // Set ints from chars cases
                    {
                        case 'X':
                            row[x] = -1;
                            break;
                        case 'S':
                            row[x] = 100;
                            break;
                        case 'G':
                            row[x] = -7;
                            break;
                        case '_':
                            row[x] = 0;
                            break;

                    }
                }
               
                Mazearray[i] = row;           // assing row in jagged array.
            }
            return Mazearray;
        }

        public void Print(int[][] Mazearray)
        {
            for (int i = 0; i < Mazearray.Length; i++)
            {
                for (int j = 0; j < Mazearray[i].Length; j++)  //the length of each array
                {
                    
                       
                        Console.Write(" " + String.Format("{0,3}", Mazearray[i][j]) + " ");//specific format to display the table
                      
                }

                Console.WriteLine();
            }
        }

        public bool validPos(int[][] Mazearray, int newRow, int newCol)
        {
            //check if we are within the boundaries of the table if we are at the boundary of rows and columns and where we go is not closed route.
            //if not then false...else true!
            if (newRow < 0 || newCol < 0 || newRow >= Mazearray.Length || newCol >= Mazearray[newRow].Length || Mazearray[newRow][newCol] == -1) return false;


            return true;
        }

        public void Solve(int[][] Mazearray)
        {
            
            int[] move_row = { -1, 0, 1, 0 }; //in order of priority: Up, right, down, left(like a clock!)
            int[] move_col = { 0, 1, 0, -1 };



            for (int i = 0; i < Mazearray.Length; i++)
            {
                for (int j = 0; j < Mazearray[i].Length; j++)
                {

                    if (Mazearray[i][j] >= 100) //here is the robot...(at the moment)
                    {


                        for (int a = 0; a < 4; a++)
                        {
                            int newRow = i + move_row[a];  //allowed movements row 
                            int newCol = j + move_col[a];  //allowed movements col  



                            // Move to a valid position
                            if (validPos(Mazearray, newRow, newCol))

                            {

                                if (Mazearray[newRow][newCol] == -7) //the exit...
                                {

                                    count++;                                      //+1 move
                                    Console.ReadLine();                           //wait for press enter
                                    Print(Mazearray);                             //call function print
                                    Console.BackgroundColor = ConsoleColor.Red;
                                    Console.WriteLine("\n------------next step!:(" + newRow + " ," + newCol + ") you find the exit!------------moves:" + count);
                                    Console.ResetColor();
                                    Console.ReadLine();
                                    Console.ReadLine();
                                    Environment.Exit(0);


                                }
                                else if (Mazearray[newRow][newCol] == 0)//open route ... we can move
                                {
                                    count++;                                         //+1 move
                                    Mazearray[newRow][newCol] = Mazearray[i][j] + 1;//we have moved...
                                                                                    //the robot now changes position ... where we give him another value to know where he is .. + 1 from the previous one!
                                    Console.BackgroundColor = ConsoleColor.Blue;
                                    Console.WriteLine("\n-----------------PRESS ENTER----------------");
                                    Console.ResetColor();
                                    Console.ReadLine();                             //press enter for the next move...
                                    
                                    Print(Mazearray);                               //call function print

                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("**we are in the position with coordinates:(" + newRow + " ," + newCol + ") and value=" + Mazearray[newRow][newCol]+"**");
                                    Console.ResetColor();
                                    Solve(Mazearray);        //recursive!
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}















       
                               
 

                           

     


                           



                               
           
 
