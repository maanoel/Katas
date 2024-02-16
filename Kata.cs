using System.Linq;

/*

Given an array (a list in Python) of integers and an integer n, find all occurrences of n in the given array and return another array containing all the index positions of n in the given array.

If n is not in the given array, return an empty array [].

Assume that n and all values in the given array will always be integers.

*/

public class Kata2
{
  public static int[] FindAll(int[] array, int n)
  {
    return Enumerable.Range(0, array.Length).Where(i=> array[i] == n).ToArray();
  }
  
  public static int[] FindAllTwo(int[] array, int n)
  {
    int index = -1;
    var indexes = new List<int>();
    
    do{
      index = Array.IndexOf(array, n, index + 1);
      
      if(index!= -1){
        indexes.Add(index);
      }
    }
    while(index != -1);
    
    return indexes.ToArray();
  }
}