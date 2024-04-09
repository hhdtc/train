// See https://aka.ms/new-console-template for more information
using ConsoleApp1;
Console.WriteLine("Hello, World!");
int[] res;
Assignment01.HackName();
Assignment01.PrintSize();
Assignment01.CenturiesToYear(5);
Assignment01.FizzBuzz(100);
Assignment01.Guess();
Assignment01.Pyramid();
Assignment01.AgeToDays(2000, 1, 1);
Assignment01.Greetings();
Assignment01.CountTo24();
Assignment02.PerformCopy();
Assignment02.ManageList();
res = Assignment02.FindPrimesInRange(0, 100);
foreach (int i in res) { 
    Console.WriteLine(i);
}

int[] arr = { 1, 2, 3, 4,5 };
res = Assignment02.ArrayRotation(arr,3);
foreach (int i in res) { 
    Console.WriteLine(i);
}

int[] arr2 = { 1,1,1,1,1,1 };
res = Assignment02.FindLongestSeq(arr2);
PrintArray(res);
int[] arr3 = { 7, 7 ,7 ,0, 2, 2, 2, 0, 10, 10, 10 };
Console.WriteLine(Assignment02.FindMostFreq(arr3));
Console.WriteLine(Assignment02.ReverseString("24tvcoi92"));
Console.WriteLine(Assignment02.ReverseStringInWords("The quick brown fox jumps over the lazy dog /Yes! Really!!!/."));
Assignment02.FindPalindromes("Hi,exe? ABBA! Hog fully a string: ExE. Bob");
Assignment02.ExtractURL("https://www.apple.com/iphone");









//helper function
static void PrintArray(int[] arr) {
    foreach (int i in arr)
    {
         Console.WriteLine(i);
    }
 }