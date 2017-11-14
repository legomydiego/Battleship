using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship
{
    class Program
    {
        static void Main(string[] args)
        {

            Random r = new Random();

            char[,] grid = new char[8, 12];

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 12; j++)
                {
                    grid[i, j] = '0';
                }
            }

            grid[(r.Next(0, 7)), (r.Next(0, 11))] = 'x';
            grid[(r.Next(0, 7)), (r.Next(0, 11))] = 'x';
            int counter = 2;


            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 12; j++)
                {
                    Console.Write(grid[i, j]);
                }
                Console.WriteLine("");
            }


            while (counter > 0)
            {
                Console.WriteLine("What is your x coordinate?");
                int user_X = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("What is your y coordinate?");
                int user_Y = Convert.ToInt32(Console.ReadLine());

                if (grid[user_X, user_Y] == 'x')
                {
                    Console.WriteLine("You sunk my Battleship!");
                    grid[user_X, user_Y] = 'y';
                    counter = counter - 1;
                    if (counter == 0)
                    {
                        Console.WriteLine("You have won the game!");
                        Console.ReadLine();
                    }

                }
                else
                {
                    if ((user_X) == 0)
                    {
                        if (grid[(user_X + 1), user_Y] == 'x'
                        || grid[(user_X), (user_Y + 1)] == 'x'
                        || grid[(user_X), (user_Y - 1)] == 'x')
                        {
                            Console.WriteLine("Close, but no cigar!");
                        }
                        else
                        {
                            Console.WriteLine("You missed, and you are a fool!");
                        }
                    }
                    if ((user_Y) == 0)
                    {
                        if (grid[(user_X + 1), user_Y] == 'x'
                                                || grid[(user_X - 1), user_Y] == 'x'
                                                || grid[(user_X), (user_Y + 1)] == 'x')
                        {
                            Console.WriteLine("Close, but no cigar!");
                        }
                        else
                        {
                            Console.WriteLine("You missed, and you are a fool!");
                        }
                    }
                    if ((user_X) == 0 && (user_Y) == 0)
                    {
                        if (grid[(user_X + 1), user_Y] == 'x'
                            || grid[(user_X), (user_Y + 1)] == 'x')
                        {
                            Console.WriteLine("Close, but no cigar!");
                        }
                        else
                        {
                            Console.WriteLine("You missed, and you are a fool!");
                        }
                    }

                    else if (grid[(user_X + 1), user_Y] == 'x'
                       || grid[(user_X - 1), user_Y] == 'x'
                       || grid[(user_X), (user_Y + 1)] == 'x'
                       || grid[(user_X), (user_Y - 1)] == 'x')
                    {
                        Console.WriteLine("Close, but no cigar!");
                    }
                    else
                    {
                        Console.WriteLine("You missed, and you are a fool!");
                    }

                }

            }
        }
    }
}