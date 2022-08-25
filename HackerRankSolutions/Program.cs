// See https://aka.ms/new-console-template for more information
using HackerRankSolutions;

Console.WriteLine("Hello, World!");

List<int> arr = new List<int>();
arr.Add(1);
arr.Add(2);
arr.Add(3);
arr.Add(4);
arr.Add(5);

List<int> res = ReverseArray.reverseArray(arr);

foreach(var i in res)
{
    Console.WriteLine(i);
}