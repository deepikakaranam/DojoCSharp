using System;

namespace multiplicationtable
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[10,10];
            for(int i=0;i<10;i++)
            {
                for(int j=0;j<10;j++){
                    array[i,j]=(i+1)*(j+1);
                }
            }
            Console.WriteLine(array[0,9]);
            var rowCount = array.GetLength(0);
            var colCount = array.GetLength(1);
            for (int row = 0; row < rowCount; row++)
            {
                for (int col = 0; col < colCount; col++)               
                    Console.Write(String.Format("{0}\t", array[row,col]));
                Console.WriteLine();
            } 
            

        }
    }
}
