﻿class Program
{
    public static void Main (string[] args) {
        int[] int_array = {11,23,31,42,53};
        ArraySum(int_array);

        int[,] array_2d = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

        PrintAllOddNumber(array_2d);

        Console.WriteLine($"\nSum of 2d array: {ElementSum(array_2d)}");

        int[,] Q2_3 = DoubleArray(array_2d);
        Console.WriteLine("The new 2d array:");
        foreach(int num in Q2_3){
                Console.Write(num +" ");
        }
    }

    public static void ArraySum(int[] int_array){
        int sum = 0;
        for(int i = 0; i < int_array.Length; i++){
            sum += int_array[i];
        }
        Console.WriteLine($"Sum of the array: {sum}");
    }

    public static void PrintAllOddNumber(int[ , ] array_2d){
        for(int i = 0; i < array_2d.GetLength(0); i++){
            for(int j = 0; j < array_2d.GetLength(1); j++){
                if(array_2d[i,j] % 2 != 0){
                    Console.Write(array_2d[i,j] + " ");
                }
            }
        }
    }

    public static int ElementSum(int[ , ] array_2d){
        int sum = 0;
        for(int i = 0; i < array_2d.GetLength(0); i++){
            for(int j = 0; j < array_2d.GetLength(1); j++){
                sum += array_2d[i,j];
            }
        }
        return sum;
    }

    public static int[ , ] DoubleArray(int[ , ] array_2d){
        int[,] doubledArray = new int[array_2d.GetLength(0), array_2d.GetLength(1)];
        for(int i = 0; i < array_2d.GetLength(0); i++){
            for(int j = 0; j < array_2d.GetLength(1); j++){
                doubledArray[i,j] = array_2d[i,j] * 2;
            }
        }
        return doubledArray;
    }  
}