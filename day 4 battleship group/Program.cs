using System;

namespace day4battleship
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the high seas of Syntax! Try to sink our Battleship! It is hidden within the Ocean of Zeros\n" + "If you miss, a '1' will show where you missed.\n" + "'9' marks a hit!");
            //untouched spaces are 0s, hits are 9s, misses are 1s

            int[,] grid = new int[8, 8]; //creating an  8x8 grid
            int tugboat = 5; //needed to give it an arbitrary value so we can hide it in the grid
            int hit = 9; //an integer to represent a hit
            int miss = 1; // an integer to represent a miss
            grid[0, 0] = tugboat; // one section of the battleship
            grid[1, 1] = tugboat; // another section of the battleship
            bool Battle = true; // boolean for running our while loop. Will turn false when game is over

            while (Battle == true) // game is in progress
            {

                for (int x = 0; x < 8; x++)
                {
                    for (int y = 0; y < 8; y++)
                    {
                        if (grid[x, y] == hit)
                        {
                            Console.Write(hit);
                        }
                        else if (grid[x, y] == miss)
                        {
                            Console.Write(miss);
                        }
                        else
                        {
                            Console.Write(0);
                        }
                    }

                    Console.WriteLine(); // will display 1s for misses, 9s for hits, and 0s for untouched water

                }

                //int checkX;
                //int checkY;
                //while (checkX < 0 || checkX > 7) COME BACK TO MAKING SURE USER INPUT IS VALID (didn't quite get here...)
                Console.WriteLine("Please choose an x coordinate (0 - 7): ");
                int userX = Convert.ToInt32(Console.ReadLine()); // user picks a whole number 0-7 for x, converted to an integer


                Console.WriteLine("Please choose an y coordinate (0 - 7): ");
                int userY = Convert.ToInt32(Console.ReadLine()); // user picks a whole number 0-7 for y, converted to an integer

                if (grid[userX, userY] == tugboat) // 
                {
                    Console.WriteLine("Hit!!");
                    grid[userX, userY] = hit;

                }



                else
                {
                    Console.WriteLine("Miss!!");
                    grid[userX, userY] = miss;
                }
                if (grid[0, 0] == hit && grid[1, 1] == hit)
                {
                    Battle = false;
                    Console.WriteLine("You win!");
                    for (int x = 0; x < 8; x++) // count x from 0 - 7
                    {
                        for (int y = 0; y < 8; y++) // count y from 0 - 7 on each value of x
                        {
                            if (grid[x, y] == hit)
                            {
                                Console.Write(hit);
                            }
                            else if (grid[x, y] == miss)
                            {
                                Console.Write(miss);
                            }
                            else
                            {
                                Console.Write(0);
                            }
                        }

                        Console.WriteLine(); // WriteLine creates new line for each x row

                    }

                }
            }
            Console.Write("You sunk my tugboat! TOOT TOOT!!!!");

        }
    }
}
