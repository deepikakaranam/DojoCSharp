using System;

namespace basic13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            PrintNumbers();
            PrintOdds();
            PrintSum();
            LoopArray(new int[]{1,2,3,4,5,6});
            FindMax(new int[]{1,2,3,4,5,6});
            GetAverage(new int[]{2,10,3});
            OddArray();
            GreaterThanY(new int[]{1,3,5,7,9}, 3);
            SquareArrayValues(new int[] {1,5,10,-10});
            EliminateNegatives(new int[] {1, 5, 10, -2});
            MinMaxAverage(new int[] {1, 5, 10, -2});
            ShiftValues(new int[] {1, 5, 10, 7, -2});
            NumToString(new int[] {-1, -3, 2});
        }
        public static void PrintNumbers()
        {
           for(int i=0;i<=255;i++){
               Console.WriteLine(i);
           }
        }
        public static void PrintOdds()
        {
            for(int i=1;i<=255;i++){
                if(i%2!=0){
                    Console.WriteLine(i);
                }
            }
        }
        public static void PrintSum()
        {
            int sum=0;
             for(int i=0;i<=255;i++){
                
               sum=sum+i;
            //    Console.WriteLine(sum);
               Console.WriteLine($"number:{i} sum:{sum} ");
               }
               
        }
        public static void LoopArray(int[] numbers)
        {
            foreach (int i in numbers){
                Console.WriteLine("{0}",i);
            }
        }
        public static void FindMax(int[] numbers)
        {
            int max = numbers[0];
            for(int i=0;i<=numbers.Length-1;i++){
               if(numbers[i]>max){
                   max= numbers[i];
                   
               }
            }
            Console.WriteLine(max);
        }
        public static void GetAverage(int[] numbers)
        {
            int sum = 0;
            for(int i=0;i<numbers.Length;i++){
                sum+=numbers[i];
            
            }
            double avg = sum/numbers.Length;
            Console.WriteLine(avg);
        }
        public static void OddArray(){
        int[] numbers = new int[130];
        int i=0;
        for(int x=1;x<=255;x++){
            if(x%2!=0){
              numbers[i]=x;  
              i++;
             Console.WriteLine(numbers[i]);
            }
        
        }
        


        }
        public static void GreaterThanY(int[] numbers, int y)
        {
            int count=0;
            for (int i=0;i<numbers.Length;i++){
               if(numbers[i]>y){
                   count+=1;
               }
            }
            Console.WriteLine(count);
            
        }
        public static void SquareArrayValues(int[] numbers)
        {
            for (int i=0;i<numbers.Length;i++){
                numbers[i]=numbers[i]*numbers[i];
                Console.WriteLine(numbers[i]);
            }    
            
        } 
        public static void EliminateNegatives(int[] numbers)
        {
            for (int i=0;i<numbers.Length;i++)
            {
                if(numbers[i]<0)
                {
                    numbers[i]=0;
                }
                Console.WriteLine(numbers[i]);    
            
            }
        
        }
        public static void MinMaxAverage(int[] numbers)
        {
            double sum =0;
            int max=numbers[0];
            int min=numbers[0];
            for (int i=0;i<numbers.Length;i++){
                sum+=numbers[i];
                if(numbers[i]>max){
                    max=numbers[i];
                }
                if(numbers[i]<min){
                    min=numbers[i];
                }
               
            }

             double avg = sum/numbers.Length;
             Console.WriteLine(avg);
             Console.WriteLine(max);
             Console.WriteLine(min);
        }

        public static void ShiftValues(int[] numbers)
        {
           for (int i=0;i<numbers.Length-1;i++){
               numbers[i]=numbers[i+1];
               Console.WriteLine(numbers[i]);
            //    numbers[numbers.Length]=0;
            //    Console.WriteLine(numbers[numbers.Length]);
           }
            numbers[numbers.Length - 1] = 0;
        }
        public static void NumToString(int[] numbers)
        {
            object[] objs = new object[numbers.Length];
            for (int i=0;i<numbers.Length-1;i++){

                if (numbers[i]<0){
                    objs[i]=numbers[i].ToString("Dojo"); // "Dojo"
                }
                else{
                    objs[i]=numbers[i];
                }
            }
            Console.WriteLine(objs);
            // Write a function that takes an integer array and returns an object array 
            // that replaces any negative number with the string 'Dojo'.
            // For example, if array "numbers" is initially [-1, -3, 2] 
            // your function should return an array with values ['Dojo', 'Dojo', 2].
        }



                }



    }

