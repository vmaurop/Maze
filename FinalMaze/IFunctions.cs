using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalMaze
{
    //An interface is defined as a syntactical contract that all the classes inheriting the interface should follow
    public interface IFunctions
    {

        int[][] GetMaze(string maze);
        bool validPos(int[][] Mazearray, int row, int col);
        void Solve(int[][] Mazearray);
        void Print(int[][] Mazearray);
    }
}

