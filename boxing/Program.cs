using System;
using System.Collections.Generic;

namespace boxing
{
    class Program
    {
        static void Main(string[] args)
        {
           List<object> mixedList = new List<object>();
           mixedList.Add(7);
           mixedList.Add(28);
           mixedList.Add(-1);
           mixedList.Add(true);
           mixedList.Add("chair");
           var sum =0;
           foreach(var item in mixedList){
               Console.WriteLine(item);
               Console.WriteLine(item.GetType());
               
               if(item is int) {
                   sum=sum+(int)item;
                  
               }
               
               
           }
           
             Console.WriteLine(sum);

        }
    }
}
