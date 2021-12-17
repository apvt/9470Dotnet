using System;
namespace jagged
{
 class jagged
 {
 public static void Main(string[] args)
 {
  int[][] arr = new int[][]
 {
 new int[] {1,2},
 new int[] {21,23,45},
 new int[] {20,14,36,57,190 }
 };
 for(int i=0; i<arr.Length;i++)
 {
 for(int j=0;j<arr[i].Length; j++)
 {
 System.Console.Write(arr[i][j] + " ");
 }
 System.Console.WriteLine();
 }
 Console.ReadLine();
 }
 }
} 