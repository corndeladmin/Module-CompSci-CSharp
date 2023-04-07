using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_CompSci_CSharp
{
    class Slot
    {
        public int Row
        {
            get;
        }

        public int Col
        {
            get;
        }

        Slot(int row, int col)
        {
            Row = row;
            Col = col;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int[,] initialBoard = new int[,] {
                { 0, 0, 0, 0, 0, 2, 1, 0, 0},
                { 0, 0, 4, 0, 0, 8, 7, 0, 0},
                { 0, 2, 0, 3, 0, 0, 9, 0, 0},
                { 6, 0, 2, 0, 0, 3, 0, 4, 0},
                { 0, 0, 0, 0, 0, 0, 0, 0, 0},
                { 0, 5, 0, 6, 0, 0, 3, 0, 1},
                { 0, 0, 3, 0, 0, 5, 0, 8, 0},
                { 0, 0, 8, 2, 0, 0, 5, 0, 0},
                { 0, 0, 9, 7, 0, 0, 0, 0, 0}
            };

            Console.WriteLine("Solving board:");
            PrintBoard(initialBoard);

            Stack<int[,]> stack = new Stack<int[,]>();
            stack.Push(initialBoard);

            while (stack.Count > 0)
            {
                int[,] board = stack.Pop();
                Slot slot = GetEmptySlot(board);

                if (slot == null)
                {
                    Console.WriteLine("Solved!");
                    PrintBoard(board);
                    Console.ReadLine();
                    return;
                }

                for (int guess = 1; guess <= 9; guess++)
                {
                    if (IsValidInSlot(board, slot, guess))
                    {
                        stack.Push(UpdateBoard(board, slot, guess));
                    }
                }
            }

            Console.ReadLine();
        }

        private static Slot GetEmptySlot(int[,] board)
        {
            throw new NotImplementedException("Fill me in!");
        }

        private static bool IsValidInSlot(int[,] board, Slot slot, int guess)
        {
            return IsValidInRow(board, slot.Row, guess) &&
                IsValidInCol(board, slot.Col, guess) &&
                IsValidInSquare(board, slot, guess);

        }

        private static bool IsValidInRow(int[,] board, int row, int guess)
        {
            throw new NotImplementedException("Fill me in!");
        }

        private static bool IsValidInCol(int[,] board, int col, int guess)
        {
            throw new NotImplementedException("Fill me in!");
        }

        private static bool IsValidInSquare(int[,] board, Slot slot, int guess)
        {
            throw new NotImplementedException("Fill me in!");
        }

        private static int[,] UpdateBoard(int[,] board, Slot slot, int guess)
        {
            throw new NotImplementedException("Fill me in!");
        }

        private static void PrintBoard(int[,] board)
        {
            for (int rowIndex = 0; rowIndex < 9; rowIndex++)
            {
                for (int colIndex = 0; colIndex < 9; colIndex++)
                {
                    Console.Write(board[rowIndex, colIndex] == 0 ? "  " : board[rowIndex, colIndex] + " ");
                }
                Console.WriteLine("");
            }
        }
    }
}
