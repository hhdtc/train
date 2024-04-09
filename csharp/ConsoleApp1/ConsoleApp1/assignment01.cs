using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Assignment01
    {
        // 1
        // telephone num: string
        // height: float
        // age: uint or ushort
        // gender: enum
        // salary: decimal
        // ISBN: string
        // book's price: decimal
        // shipping weight: float/double
        // population: long
        // # of starts in universe: long/BigInteger
        // The number of employees in each of the small or medium businesses in the United Kingdom(up to about 50,000 employees per business)ushort or uint

        // 2
        // value type stores the actual value in stack. Reference type stores the address in the stack, and the address points to heap. The actual value of refernce type is in heap.
        // boxing: value type -> reference type
        // unboxing: reference type -> value type

        // 3
        // managed resource: the object will be managed by  CLR and clean by garbage collector automatically.
        // unmanaged resource: the object will be cleaned manually by calling the dispose method from IDisposable interface

        // 4
        // prevent memory leak, reduce heap usage,manage the heap usage, and optimise performance.


        // Test your knowledge:
        // 1.What happens when you divide an int variable by 0?
        // It will not compile and ide gives DivideByZeroException
        
        // 2.What happens when you divide a double variable by 0?
        // (positive double)/0=(positive infinity), (negative double)/0=(negative infinity)
        
        // 3.
        // it will go to the other end.e.x. If it exceed max number, it will start from min number.

        // 4
        // x=y++ => x=y, then y+=1
        // x=++y => y+=1, then x=y

        // 5
        // break will jump out of the loop
        // continue will ignore the rest code inside the loop and start the next turn
        // return will exit the function. It will also break the loop

        // 6
        // initializing: int i=0;
        // condition: i<10;
        // iteration: i++;

        // 7
        // =:respresent assgining the right value to the left
        // ==:comparison operator.

        // 8
        // yes; infinite for loop

        // 9
        // default case

        // 10
        // IEnumerable or IEnumerable<T>



        // Practice loops and operators
        // 1
        // byte's max value is 255. It will loop forever.


        // add folowing before the code
        // if (max > byte.MaxValue){
        //  Debug.Log("infinite loop!!");
        // }

        // 3



        public static void HackName() {
            Console.WriteLine("What is your favorite color?");
            string favoriteColor = Console.ReadLine();
            Console.WriteLine("What is your astrology sign?");
            string astrologySign = Console.ReadLine();
            Console.WriteLine("What is your street address number?");
            int streetAddress = int.Parse(Console.ReadLine());
            Console.WriteLine($"Your hacker name is {favoriteColor}{astrologySign}{streetAddress}");
        }

        public static void PrintSize() {
            PrintLine("sbyte", sizeof(sbyte), sbyte.MinValue, sbyte.MaxValue);
            PrintLine("byte", sizeof(byte), byte.MinValue, byte.MaxValue);
            PrintLine("short", sizeof(short), short.MinValue, short.MaxValue);
            PrintLine("ushort", sizeof(ushort), ushort.MinValue, ushort.MaxValue);
            PrintLine("int", sizeof(int), int.MinValue, int.MaxValue);
            PrintLine("uint", sizeof(uint), uint.MinValue, uint.MaxValue);
            PrintLine("long", sizeof(long), long.MinValue, long.MaxValue);
            PrintLine("ulong", sizeof(ulong), ulong.MinValue, ulong.MaxValue);
            PrintLine("float", sizeof(float), float.MinValue, float.MaxValue);
            PrintLine("double", sizeof(double), double.MinValue, double.MaxValue);
            PrintLine("decimal", sizeof(decimal), decimal.MinValue, decimal.MaxValue);
        }

        private static void PrintLine(string name, int size, dynamic minValue, dynamic maxValue) {
            Console.WriteLine($"name:{name} size:{size} min:{minValue} max: {maxValue}");
        }

        public static void CenturiesToYear(int n) {
            long years = n * 100L;
            long days = (long)(365.2422 * years);
            decimal hours = days * 24M;
            decimal minutes = hours * 60M;
            decimal seconds = minutes * 60M;
            decimal milliseconds = seconds * 1000M;
            decimal microseconds = milliseconds * 1000M;
            decimal nanoseconds = microseconds * 1000M;

            Console.WriteLine($"{n} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes = {seconds} seconds = {milliseconds} milliseconds = {microseconds} microseconds = {nanoseconds} nanoseconds");
        }


        public static void FizzBuzz(int n) {
            if (n < 0){
                return;
            }
            for (int i = 0; i <= n; i++) {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("fizzbuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("buzz");
                }
                else {
                    Console.WriteLine(i);
                }
            }
        }


        public static void Guess() {
            int g = -1;
            int correctNumber = new Random().Next(3) + 1;
            while (g != correctNumber) {
                Console.WriteLine("take a guess! 1-3");
                g = int.Parse(Console.ReadLine());
                if (g < 1 || g > 3) {
                    Console.WriteLine("out of range");
                    continue;
                }
                if (g < correctNumber)
                {
                    Console.WriteLine("guess higher");
                }
                else if (g > correctNumber)
                {
                    Console.WriteLine("guess lower");
                }
                else {
                    Console.WriteLine("correct!!");
                    return;
                }
            }
        }

        public static void Pyramid() {
            int height = 5;
            for (int i = 0; i < height; i++) {
                String result = "";
                if (4 - i > 0) {
                    result = result.PadLeft(4 - i, ' ');
                }
                result = result.PadRight(4 - i+(2 * i)+ 1, '*');
                Console.WriteLine(result);
            }
        }

        public static void AgeToDays(int year, int month, int day) {
            DateTime birthDate = new DateTime(year, month, day);
            TimeSpan ageInDays = DateTime.Now - birthDate;
            Console.WriteLine($"You are approximately {ageInDays.Days} days old.");
            Console.WriteLine($"You are {10000 - (ageInDays.Days % 10000)} days to anniversary.");

        }

        public static void Greetings() {

            DateTime currentTime = DateTime.Now;
            int hour = currentTime.Hour;
            if (hour >= 5 && hour <= 10)
            {
                Console.WriteLine("good morning");
            }
            else if (hour > 10 && hour <= 17)
            {
                Console.WriteLine("good afternoon");
            }
            else if (hour > 17 && hour <= 21)
            {
                Console.WriteLine("good evening");
            }
            else {
                Console.WriteLine("good night");
            }
        }

        public static void CountTo24() {
            for (int incr = 1; incr <= 4; incr++)
            {
                for (int i = 0; i <= 24; i += incr)
                {
                    if (i == 24)
                    {
                        Console.WriteLine(i);
                    }
                    else
                    {
                        Console.Write($"{i}, ");
                    }
                }
            }
        }


    }




   }
