using System;

namespace ReverseMultiplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter a Number between 3 and 9: ");
            var size = int.Parse(Console.ReadLine());
            var option = 1;

            int[,] table = new int[size, size];
            for (var i = 0; i < size; i++)
            {
                for (var j = 0; j < size; j++)
                {
                    table[i,j] = (i+1)*(j+1);
                    Console.Write(table[i,j]);
                    Console.Write(" ");
                }
                Console.WriteLine("");
            }
            while (option != 5)
            {
                Console.WriteLine("Flip on 1) Horizon, 2) Vertical, 3) Diagonal Left, 4) Diagonal Right, 5) To End: ");
                option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        table = FlipOnHorizontal(table, size);
                        PrintTable(table, size);
                        break;
                    case 2:
                        table = FlipOnVertical(table, size);
                        PrintTable(table, size);
                        break;
                    case 3:
                        table = FlipDiagonalLeft(table, size);
                        PrintTable(table, size);
                        break;
                    case 4:
                        table = FlipDiagonalRight(table, size);
                        PrintTable(table, size);
                        break;
                    case 5:
                        break;
                }
            }
        }

        static void PrintTable(int [,] table,int size)
        {
            for (var i = 0; i < size; i++)
            {
                for (var j = 0; j < size; j++)
                {
                    Console.Write(table[i, j]);
                    Console.Write(" ");
                }
                Console.WriteLine("");
            }
        }

        static int[,] FlipOnHorizontal(int [,] table,int size)
        {
            int[,] newTable = new int[size, size];
            size = size - 1;
            for (var i = 0; i <= size; i++)
            {
                for (var j = 0; j <= size; j++)
                {
                    newTable[i, j] = table[size - i, j];
                }
            }
            return newTable;
        }

        static int[,] FlipOnVertical(int[,] table, int size)
        {
            int[,] newTable = new int[size, size];
            size = size - 1;
            for (var i = 0; i <= size; i++)
            {
                for (var j = 0; j <= size; j++)
                {
                    newTable[i, j] = table[i,size - j];
                }
            }
            return newTable;
        }

        static int[,] FlipDiagonalLeft(int[,] table, int size)
        {
            int[,] newTable = new int[size, size];
            size = size - 1;
            for (var i = 0; i <= size; i++)
            {
                for (var j = 0; j <= size; j++)
                {
                    newTable[i, j] = table[size - i, size - j];
                }
            }
            return newTable;
        }

        static int[,] FlipDiagonalRight(int[,] table, int size)
        {
            int[,] newTable = new int[size, size];
            size = size - 1;
            for (var i = 0; i <= size; i++)
            {
                for (var j = 0; j <= size; j++)
                {
                    newTable[i, j] = table[j,i];
                }
            }
            return newTable;
        }
    }
}
