using System;


namespace week1_Assignment
{
    class Util
    {
        public static string GetString(string question)
        {
            Console.WriteLine(question);
            return Console.ReadLine();
        }
        public static int GetNumber(string question)
        {
            return int.Parse(GetString(question));
        }
        class Assignment2
        {
            static void Main(string[] args)
            {
                EvenOdd();
            }

            private static void EvenOdd()
            {
                int size = GetNumber("Enter the size");
                int[] array = new int[size];
                int[] even = new int[size];
                int[] odd = new int[size];
                int j = 0, k = 0;
                for (int i = 0; i < size; i++)
                    array[i] = GetNumber("Enter the element");
                foreach(int element in array)
                {
                    if (element % 2 == 0)
                    {
                        even[j] = element;
                        j++;
                    }
                    else
                        {
                        odd[k] = element;
                        k++;
                    }
                        
                }
               
                    display("Even numbers are", even);
                    display("Odd numbers are", odd);
                }
            }

            private static void display(string v1, int[] v2)
            {
                Console.WriteLine(v1);
                foreach(int element in v2)
                {
                if (element != 0)
                    Console.WriteLine(element);
                else
                    continue;
                }
            }
        }
    }

