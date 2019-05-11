using System;
using System.Collections.Generic;

namespace puzzles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            randomArray();
            
            tossingCoin();
            tossMultipleCoin(6);
            Names();
           
            
        }
        public static void randomArray()
        {
            int[] array = new int[10];
            int i=0;
            Random rand = new Random();
            for(int val = 0; val < 10; val++)
            {
                Console.WriteLine(rand.Next(5,25));
                int x=rand.Next(5,25);
                array[i]= x;
                i++;
            }
            Console.WriteLine(array);
        }
        public static void tossingCoin()
        {
            
            Console.WriteLine("tossing coin");
            int heads=1;
            int tails=2;
            Random rand = new Random();
            
            if(rand.Next(0,3)==heads)
            {
                Console.WriteLine("its Head");
            } 
            else
            {
                Console.WriteLine("its Tail");
            }
        }
        public static void tossMultipleCoin(int num)
        {
            int heads=1;
            int tails=2;
            double countHead=0;
            double countTail=0;
            
            for(int i=0;i<=num;i++)
                {
                
                Random rand = new Random();
                
                if(rand.Next(0,3)==heads)
                {
                    Console.WriteLine("its Head");
                    countHead+=1;
                } 
                else
                {
                    Console.WriteLine("its Tail");
                    countTail+=1;
                }
                

            }
            double ratio= countHead/countTail;
            Console.WriteLine(countHead);
            Console.WriteLine(countTail);
            Console.WriteLine(ratio);

            
        }
        public static void Names()
        {
            List<string> names = new List<string>();
            names.Add("Todd");
            names.Add("Tiffany");
            names.Add("Charlie");
            names.Add("Geneva");
            names.Add("Sydney");
            List<string> randomList = new List<string>();
            Random rand = new Random();
            int randomIndex = 0;
            while (names.Count > 0)
            {
                randomIndex = rand.Next(0, names.Count); //Choose a random object in the list
                randomList.Add(names[randomIndex]); //add it to the new, random list
                names.RemoveAt(randomIndex); //remove to avoid duplicates
            }

           Console.WriteLine(randomList); //return the new random list
           for (int i=0;i<randomList.Count;i++)
           {
               if (randomList[i].Length<5)
               {
                   randomList.Remove(randomList[i]);
               }
           }
           Console.WriteLine(randomList); 
        }
            
    }

}
