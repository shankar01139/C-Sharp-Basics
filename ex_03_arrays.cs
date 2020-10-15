using System;
using System.Collections;
using System.Linq;				
public class Program
{
	public static void Main()
	{
		Console.WriteLine("C# Arrays.....");
		Console.WriteLine("Inserting Values into Array with for loop.....");
		Console.WriteLine("Count Of Array Elements : ");
		int count=Convert.ToInt32(Console.ReadLine());
			int[] arr = new int[10]; 
    		int i;   
    	Console.Write("Input "+count+" elements in the array :\n");  
    	for(i=0; i<count; i++)  
    	{  
	    	Console.Write("element - {0} : ",i+1);
			arr[i] = Convert.ToInt32(Console.ReadLine());  		
   		 }
		Console.WriteLine("Array Elements:");
		for(i=0; i<count; i++)  
    	{  
	    	Console.Write(" "+arr[i]);
   		 }
		Console.WriteLine("");
		Console.WriteLine("Array Length :");
		Console.WriteLine(arr.Length);
		int[] myNum = {5, 1, 8, 9};
		Console.WriteLine("Array Elements Accessing with foreach loop");
		foreach (int j in arr) {	
  			Console.WriteLine(j);
		}
		Console.WriteLine("Array Sorting:");
		Array.Sort(myNum);
		foreach (int j in myNum){
		 	 Console.WriteLine(j);
		}
		Console.WriteLine("Max--Min--Sum Functions....");
		Console.WriteLine(myNum.Max());
      	Console.WriteLine(myNum.Min());  
      	Console.WriteLine(myNum.Sum());
		Console.WriteLine("Adding Elements with add method.....");
		ArrayList myList = new ArrayList();
		Console.WriteLine("How Many Elements You Want to add.....");
		int s=Convert.ToInt32(Console.ReadLine());
		for(int u=0;u<s;u++){
			Console.Write("element - {0} : ",u+1);
			int v=Convert.ToInt32(Console.ReadLine());
			myList.Add(v);
		}
		Console.WriteLine("Array after Add...");
		for(int u=0;u<s;u++){ 
         		Console.WriteLine(myList[u]);
		}
		myList.Insert(0,100);
		myList.Insert(1,100);
		
		Console.WriteLine("Array after Insert ...");
		for(int u=0;u<s;u++){ 
			Console.WriteLine(myList[u]);
		}
		myList.AddRange(arr);
		for(int u=0;u<s;u++){ 
			Console.WriteLine(myList[u]);
		}
	}
}
