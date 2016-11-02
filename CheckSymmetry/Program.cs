using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckSymmetry
{
    class Program
    {
        static void Main(string[] args)
        {

            do
            {

                int NumberOfRows = 0;
                int NumberOfColumns = 0;
                bool symmetric;
                Console.WriteLine("Please enter the number of rows");
                NumberOfRows = int.Parse(Console.ReadLine());
                Console.WriteLine("Please enter the number of columns");
                NumberOfColumns = int.Parse(Console.ReadLine());

                int [,] manualArray = CreateArrayManual(NumberOfRows, NumberOfColumns);
                symmetric = CheckSym(manualArray, NumberOfRows, NumberOfColumns);

                if (symmetric)
                {
                    Console.WriteLine("Array is symmetric");
                }
                else
                {
                    Console.WriteLine("Array is not symmetric");
                }


                int[,] symmetricArray = CreateArrayAutoSymmetric(NumberOfRows, NumberOfColumns);
                symmetric = CheckSym(symmetricArray, NumberOfRows, NumberOfColumns);
                if (symmetric)
                {
                    Console.WriteLine("Array is symmetric");
                }
                else
                {
                    Console.WriteLine("Array is not symmetric");
                }


                int[,] unsymmetricArray = CreateArrayAutoUnSymmetric(NumberOfRows, NumberOfColumns);
                symmetric = CheckSym(unsymmetricArray, NumberOfRows, NumberOfColumns);

                if (symmetric)
                {
                    Console.WriteLine("Array is symmetric");
                }
                else
                {
                    Console.WriteLine("Array is not symmetric");
                }

            } while (keepGoing());
        }

        private static int[,] CreateArrayAutoSymmetric(int NumberOfRows, int NumberOfColumns)
        {
           
            int[,] output = new int[NumberOfRows, NumberOfColumns];
            for (int row = 0; row < NumberOfRows; row++)
            {
                for (int column = 0; column < NumberOfColumns; column++)
                {
                    
                    output[row, column] = 0;
                    Console.WriteLine("The value for array {0}{1} = {2} ", row, column, output[row, column]);
                }
            }
            return output;
        }

        private static int[,] CreateArrayAutoUnSymmetric(int NumberOfRows, int NumberOfColumns)
        {
            int[,] output = new int[NumberOfRows, NumberOfColumns];
            int ctr = 0;
            for (int row = 0; row < NumberOfRows; row++)
            {
                for (int column = 0; column < NumberOfColumns; column++)
                {

                    output[row, column] = ctr++;
                    Console.WriteLine("The value for array {0}{1} = {2} ", row, column, output[row, column]);
                }
            }
            return output;
        }

        private static int [,] CreateArrayManual(int NumberOfRows, int NumberOfColumns)
        {
            int[,] output = new int[NumberOfRows, NumberOfColumns];
            for (int row = 0; row < NumberOfRows; row++)
            {
                for (int column = 0; column < NumberOfColumns; column++)
                {
                    Console.WriteLine("Enter value for row: {0} and column {1}", row, column);
                    output[row, column] = int.Parse(Console.ReadLine());

                }
            }
            return output;
        }

        static bool CheckSym(int[,] a1, int NumberOfRows, int NumberOfColumns)
        {
            int[,] a2 = new int[NumberOfRows, NumberOfColumns];
            //Array.Copy(a1, a2,NumberOfRows);

            for (int row = 0; row < NumberOfRows; row++)
            {
                for (int column = 0; column < NumberOfColumns; column++)
                {
                    
                    a2[row, column] = a1[column, row];
                }
            }

            for (int row = 0; row < NumberOfRows; row++)
            {
                for (int column = 0; column < NumberOfColumns; column++)
                {
                    Console.WriteLine("Compare array1 [{0},{1}] to array 2 [{2},{3}] = {4} {5}",row,column,column,row,a1[row,column],a2[row,column]);
                    if (a1[row, column] != a2[row,column])
                    {
                        
                        return false;
                    }
                }
            }
            

            return true;

        }



        static bool keepGoing()
        {
            /* Name: keepGoing
            * Description:  This method implements a loop to determine if users wants to continue
            * Input:  None
            * Output: Returns false if user doesn't want to continue.  Otherwise returns true.
            *         Outputs values to Console
            */


            // If user enters "q", execute exit procedure
            Console.WriteLine("\nContinue? (y/n):");
            string input = Console.ReadLine();

            if (input == "n")
            {
                Console.WriteLine("You entered n\n");
                Console.WriteLine("Are you sure you want to exit? (Type y to confirm)");
                input = Console.ReadLine();

                if (input == "y")
                {
                    return false;
                }

            }

            return true;
        }




    }
}
