namespace Day_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Array
            //example

            int[] numbers = new int[5] { 1, 2, 3, 4, 5  };

            //Array Declaration

            int[] arr = new int[3];

            //Innitalization

            arr[0] = 1;
            arr[1] = 2;
            arr[2] = 3;

            //Initialization and Declaration in One Line

            int[] arr1 = new int[3] { 3, 4, 5, };

            //Syntax sugar for array 

            string[] strings = { "Ahmed", "Sara", "Hamad" };


            //Multi=diemensonal array

            int[,] matrix = new int[3, 3];

            //declare and initialize a two-diemensional integer array with diemensions 3*3

            matrix[0, 0] = 1;
            matrix[0, 1] = 2;
            matrix[1, 0] = 3;
            matrix[1, 1] = 4;
            matrix[2, 0] = 5;
            matrix[2, 1] = 6;

            //Jagged Array

            int[][] jaggedArray = new int[3][];
            jaggedArray[0] = new int[] { 1, 2, 3 };
            jaggedArray[1] = new int[] { 4,5 };
            jaggedArray[2] = new int[] { 6, 7, 8, 9};


            //Jagged Array using initializer list

            int[][] jaggedArray1 = new int[][]
            {
                new int[] {1, 2, 3, },
                new int[] {4,5},
                new int[] {6,7,8,9}

            };


            //Array Slicing

            int[] numbers = new int[] { 1, 2, 3, 4, 5 };
            int[] slice = numbers[1..4];
            Console.WriteLine(slice[0]);


            //Reverse Slicing

            var slice3 = numbers[2, ..2 ^];
            Console.WriteLine(slice3[0]);


            //Write a program in C# Sharp to merge two arrays of the same size sorted in ascending order.

            int[] ls1 = { 1, 2, 3, 4, 5, 6 };
            int[] ls2 = { 7, 8, 9, 10, 11, 12 };
            ls1 = ls1.Concat(ls2).ToArray();
            Array.Sort(ls1);
            foreach (int j in ls1)
            {
                Console.Write(j + " ");
            }









        }
    }
}
