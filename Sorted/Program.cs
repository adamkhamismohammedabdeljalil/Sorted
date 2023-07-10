using System.Linq;
using System.Security.Cryptography;

var random = new Random();

var range = Enumerable.Range(0, 1000).Select(number => random.Next(0, 2000)).ToList();

Console.WriteLine("Sorted numbers");

printAll(GetSortedNumbersQuery(range));
Console.WriteLine("Sorted numbers in reverse");
printAll(GetSortedNumbersQueryReversed(range));

IEnumerable<int> GetSortedNumbersQueryReversed(List<int> range)
{
    return from number in range
           orderby number descending
           select number;
    
}

IEnumerable<int> GetSortedNumbersQuery(List<int> range)
{
    return from number in range
           orderby number 
           select number;

}

void printAll(IEnumerable<int> numbers)
{
    foreach (var number in numbers)
    {
        Console.WriteLine(number + " ");
    }
    Console.WriteLine();
}
foreach (var item in range)
{
    Console.WriteLine(item);
}

