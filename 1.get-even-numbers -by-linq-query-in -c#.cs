using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var numbers = new List<int> { 1, 2, 3, 4, 5 };
        //Query Systax
		var evenNumbers = from n in numbers where n % 2 == 0 select n;
		
		//Method Systax
		var evenNubmers1=numbers.Where(n=>n%2==0);

        Console.WriteLine("Query Even Numbers:");
        evenNumbers.ToList().ForEach(n => Console.WriteLine(n));
		 Console.WriteLine("Method Even Numbers:");
		evenNubmers1.ToList().ForEach(n => Console.WriteLine(n));
    }
}
