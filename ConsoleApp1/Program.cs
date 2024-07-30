using System;
class Program
{
   static void Main(string[] args)
   {
       int M = 1;
       int N = 5;
       PrintNumbersInRange(M, N);
   }
   static void PrintNumbersInRange(int start, int end)
   {
       if (start <= end)
       {
           Console.Write(start);
           if (start < end)
               Console.Write(", ");
           PrintNumbersInRange(start + 1, end);
       }
   }
}
