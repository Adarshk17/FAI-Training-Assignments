using System;


namespace week1_Assignment
{
    class Assignment4
    {
        static void Main(string[] args)
        {
            int size = Util.GetNumber("Enter the size of an array");
            int[] array = new int[size];
            for (int i = 0; i < size; i++)
                array[i] = Util.GetNumber("Enter the array element");
            evenodd(array);
        }

        private static void evenodd(int[] array)
        {
            int evensum = 0, oddsum = 0;

            foreach (int element in array)
            {
                if (element % 2 == 0)
                    evensum += element;
                else
                    oddsum += element;

            }
            Console.WriteLine("Sum of even numbers is " + evensum);
            Console.WriteLine("Sum of odd numbers is " + oddsum);
        }
    }
}
