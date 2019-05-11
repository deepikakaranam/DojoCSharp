using System;
using System.Collections.Generic;

namespace collections
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr;
            arr = new int[] {0,1,2,3,4,5,6,7,8,9};
            for (int i=0; i<arr.Length;i++)
            {
                 Console.WriteLine(arr[i]);
            }
            foreach (int val in arr)
            {
                Console.WriteLine(val);
            }
           
            string[] arrstr;
            arrstr = new string[] { "Tim", "Martin", "Nikki",  "Sara"};
            bool[] arr1 = new bool[10];
            for (int i=0;i<arr1.Length;i++){
                if (i%2==0)
                {
                    arr1[i]=true;
                }
                else{
                    arr1[i]= false;
                }
                
            }
            Console.WriteLine(arr1[8]);
            List<string> flavors = new List<string>();
            flavors.Add("Vanilla");
            flavors.Add("butterscotch");
            flavors.Add("chocolate");
            flavors.Add("Strawberry");
            
            Console.WriteLine(flavors.Count);
            Console.WriteLine(flavors[2]);
            flavors.Remove("chocolate");
            Console.WriteLine(flavors.Count);
            Dictionary<string,string> favourite = new Dictionary<string,string>();
            // favourite.Add("Tim", "");
            // favourite.Add("Martin", "");
            // favourite.Add("Nikki", "");
            // favourite.Add("Sara", "");
            favourite.Add("Tim", "Vanilla");
            favourite.Add("Martin", "Strawberry");
            favourite.Add("Nikki", "chocolate");
            favourite.Add("Sara", "butterscotch");
            foreach (KeyValuePair<string,string> entry in favourite)
                {
                Console.WriteLine(entry.Key + " - " + entry.Value);
                }
        }
    }
}
