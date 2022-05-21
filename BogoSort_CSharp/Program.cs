using System;

namespace BogoSort_CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            int arrSize = Int32.Parse(Console.ReadLine());
            int count = 0;
            int[] arr = new int[arrSize];

            //filling the array with random elements;
            for(int i = 0; i < arrSize; i++)
            {
                arr[i] = rand.Next(0, 10000);
            }

            while(!isSorted(arr))
            {
                Shuffle(rand, arr);
                count++;
            }

            for(int i = 0; i < arr.Length; i++) 
            {
                Console.WriteLine(arr[i]);
            }
            Console.WriteLine("++++++++++++++++++++++++");
            Console.WriteLine(count);
            Console.ReadLine();
        }

        private static bool isSorted(int[] numberList)
        {
            for(int i = 0; i < numberList.Length - 1; i++)
            {
                if(numberList[i] > numberList[i+1])
                {
                    return false;
                }
            }
            return true;
        }

        public static void Shuffle(Random rng, int[] array)
        {
            int n = array.Length;
            while(n > 1)
            {
                int k = rng.Next(n--);
                int temp = array[n];
                array[n] = array[k];
                array[k] = temp;
            }
        }
    }
}
