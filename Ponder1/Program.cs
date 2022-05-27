// Week 01 Ponder: Tic-Tac-Toe
// Author: Jenna Scholl

using System;
using System.Collections.Generic;

namespace Ponder1
{
    class Program
    {
        public static string getPlayer(string current)
        {
            if (current == "" || current == "o")
                return "x";
            else
                return "o";
        }
        public static List<string> createBoard()
        {
            List<string> board = new List<string>();
            for (int i = 0; i < 9; i++)
            {
                board.Add($"{i+1}");
            }
            return board;
        }
        public static void displayBoard(List<string> board)
        {
            Console.WriteLine($"\n{board[0]}|{board[1]}|{board[2]}");
            Console.WriteLine("-+-+-");
            Console.WriteLine($"{board[3]}|{board[4]}|{board[5]}");
            Console.WriteLine("-+-+-");
            Console.WriteLine($"{board[6]}|{board[7]}|{board[8]}\n");
        }
        public static List<string> makeMove(List<string> board, String player)
        {
            Console.WriteLine($"{player}'s turn to choose a square (1-9): ");
            int square = int.Parse(Console.ReadLine());
            board[square - 1] = player;
            return board;
        }
        public static Boolean isDraw(List<string> board)
        {
            for(int i = 0; i < 9; i++)
            {
                if (board[i] != "x" && board[i] != "o")
                    return false;
            }
            return true;
        }
        public static Boolean hasWinner(List<string> board)
        {
            if((board[0] == board[1] && board[0] == board[2]) ||
              (board[3] == board[4] && board[3] == board[5]) ||
              (board[6] == board[7] && board[6] == board[8]) ||
              (board[0] == board[3] && board[0] == board[6]) ||
              (board[1] == board[4] && board[1] == board[7]) ||
              (board[2] == board[5] && board[2] == board[8]) ||
              (board[0] == board[4] && board[0] == board[8]) ||
              (board[2] == board[4] && board[2] == board[6]))
                return true;
            return false;
        }
        static void Main(string[] args)
        {
            string player = getPlayer("");
            List<string> board = createBoard();
            displayBoard(board);
            
            while(!hasWinner(board) && !isDraw(board))
            {
                makeMove(board, player);
                displayBoard(board);
                player = getPlayer(player);
            }

            Console.WriteLine("Good game. Thanks for playing!\n");
        }
    }
}
