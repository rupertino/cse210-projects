using System;

/* 
 * Tic Tac Toe Game
 * Date: 09-24-2022
 * Student: Roberto Jesus Ramirez Carbajal
 * Class: CSE210 BYU IDAHO
*/

namespace SandBoxProject
{
    class Program
    {
	    public static void Main()
	    {
            
            // Definition of variables
            int cont = 0;
            int turn, moves, pos;
            string p1, p2, p3, p4, p5, p6, p7, p8, p9;
            string player1, player2, mark;
            bool final;
            // Generate aleatory numbers
            Random rd = new Random();
            // Get names of players
            Console.Write("Name of player 1: ");
            player1 = Console.ReadLine();
            Console.Write("Name of player 2: ");
            player2 = Console.ReadLine();
            do
            {
                // Restart variables for each game
                turn = 0;
                moves = 0;
                pos = 0;
                p1 = "1";
                p2 = "2";
                p3 = "3";
                p4 = "4";
                p5 = "5";
                p6 = "6";
                p7 = "7";
                p8 = "8";
                p9 = "9";
                mark = "";
                final = false;
                // Definition of turn
                turn = rd.Next(1, 2);
                // this cycle repeats until the game is finished
                do
                {
                    Console.Clear();
                    if (turn == 1)
                    {
                        Console.WriteLine("Turn for {0}", player1);
                        mark = "X";
                        turn = 2;
                    }
                    else
                    {
                        Console.WriteLine("Turn for {0}", player2);
                        mark = "O";
                        turn = 1;
                    }

                    // Print board
                    Console.WriteLine(" ");
                    Console.WriteLine("{0}|{1}|{2}", p1, p2, p3);
                    Console.WriteLine("-+-+-");
                    Console.WriteLine("{0}|{1}|{2}", p4, p5, p6);
                    Console.WriteLine("-+-+-");
                    Console.WriteLine("{0}|{1}|{2}", p7, p8, p9);
                    Console.WriteLine(" ");
                    askposition:
                    
                    // Get position to put the actual mark
                    Console.Write("Choose a position: ");
                    pos = Convert.ToInt16(Console.ReadLine());
                    
                    // Determines in which variable will be placed
                    switch (pos)
                    {
                        case 1:
                            if (p1 == "1")
                                p1 = mark;
                            else
                                goto askposition;
                            break;
                        case 2:
                            if (p2 == "2")
                                p2 = mark;
                            else
                                goto askposition;
                            break;
                        case 3:
                            if (p3 == "3")
                                p3 = mark;
                            else
                                goto askposition;
                            break;
                        case 4:
                            if (p4 == "4")
                                p4 = mark;
                            else
                                goto askposition;
                            break;
                        case 5:
                            if (p5 == "5")
                                p5 = mark;
                            else
                                goto askposition;
                            break;
                        case 6:
                            if (p6 == "6")
                                p6 = mark;
                            else
                                goto askposition;
                            break;
                        case 7:
                            if (p7 == "7")
                                p7 = mark;
                            else
                                goto askposition;
                            break;
                        case 8:
                            if (p8 == "8")
                                p8 = mark;
                            else
                                goto askposition;
                            break;
                        case 9:
                            if (p9 == "9")
                                p9 = mark;
                            else
                                goto askposition;
                            break;
                        default:
                            goto askposition;
                    }

                    // Determine if there is a winner after the move
                    if (p1 == p2 && p2 == p3 && p3 == mark) // First Row
                        final = true;
                    else if (p4 == p5 && p5 == p6 && p6 == mark) // Second Row
                        final = true;
                    else if (p7 == p8 && p8 == p9 && p9 == mark) // Third Row
                        final = true;
                    
                    if (p1 == p4 && p4 == p7 && p7 == mark) // Firs Column
                        final = true;
                    else if (p2 == p5 && p5 == p8 && p8 == mark) // Second Column
                        final = true;
                    else if (p3 == p6 && p6 == p9 && p9 == mark) // Third Column
                        final = true;
                    
                    if (p1 == p5 && p5 == p9 && p9 == mark) // Primera diagonal
                        final = true;
                    else if (p3 == p5 && p5 == p7 && p7 == mark) // Segunda diagonal
                        final = true;
                    
                    // Increase the number of moves (1-9)
                    moves++;
                }
                while (final == false && moves < 9);
                
                // Verify if there is a winner
                if (final == false)
                    Console.WriteLine("No winner");
                else if (mark == "X")
                {
                    Console.WriteLine("Winner: {0}", player1);
                    //j1++;
                }
                else if (mark == "O")
                {
                    Console.WriteLine("Winner: {0}", player2);
                    //j2++;
                }

                //Console.WriteLine("Points of {0}: {1} pts", player1, j1);
                //Console.WriteLine("Points of {0}: {1} pts", player2, j2);
                Console.Write("Do you want to play again?: (0-No   1-Yes)");
                cont = Convert.ToInt16(Console.ReadLine());
            }
            while (cont != 0);
        }
    }
}