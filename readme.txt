



IDE:Visual studio 2015
programming language:C#
console application


-----------------------------------------------------------------------------------------------------------------------------------------

input format:text file,relative path..Maze.txt.(i add many files for practice)


text file with
contents similar to the following example:
____G__X
___XXX__
X______X
__XXXX__
___X____
__S__X__


S:Starting point
G:Exit(final point)
_:open route
X:closed route
(in capital letters)

On the program I read the archive and convert it into a matrix(jagged array)

S--->100   Starting point
G--->-7    Exit(final point)
X---->-1    open route
_ ---->0    closed route


So we have:

0   0   0   0  -7   0    0   -1
0   0  -1  -1  -1   0    0    0
-1  0   0   0   0   0    0   -1    (Sample maze definition)
0   0   -1  -1  -1  -1   0    0
0   0    0   -1  0   0   0    0
0   0    100  0   0  -1  0    0


**coordinates starting (0,0)**
so we started from position with value=100 with coordinates (5,2). The goal is to get to position -7(exit) with coordinates (0,4) 
 

the user sees real-time movements as he pushes ENTER
as values change, we see the parts which have been explored




                              
                                   

                            -----all details are described in  the code(with comments)----








