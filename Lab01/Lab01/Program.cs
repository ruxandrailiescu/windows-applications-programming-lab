using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------- EXAMPLE 1 - Hello World -----------");

            Console.WriteLine("Hello world!"); // used to print text to the console
            Console.ReadLine();                // used to read a line of input from the console
                                               // without it, the console window might close immediately after printing the text

            Console.WriteLine("----------- EXAMPLE 2 - Reading and Writing using System.Console -----------");

            // Write: Outputs text to the console without moving to the next line.
            // WriteLine: Outputs text to the console and moves to the next line.

            // Read: Reads a single character from the console without waiting for Enter. Doesn't move to the next line.
            // ReadLine: Reads a line of text from the console, waiting for Enter. Moves to the next line after user input.

            int foo = 10;
            int bar = 20;

            Console.WriteLine("String concatenation example -> foo: " + foo + " bar: " + bar);

            Console.WriteLine("Composite formatting example -> foo: {0} bar: {1}", foo, bar);
            Console.WriteLine("Composite formatting example -> {1}, {0}, {2}", 10, 20, 30);

            // String interpolation - the values will be substituted into the string at runtime
            Console.WriteLine($"{foo} {bar}");

            // {0:c} is a format specifier
            // The :c format specifier is used to format a numeric value (foo) as a currency
            Console.WriteLine("c format: {0:c}", foo);
            Console.ReadLine();

            //Console.WriteLine("----------- EXAMPLE 3 - Specifying an Application Error Code -----------");
            // (replace void with int!! static int Main(string[] args))
            //Console.WriteLine("Hello world!");
            //Console.ReadLine();
            //return -1;

            //Console.WriteLine("----------- EXAMPLE 4 - Processing Command-Line Arguments -----------");
            // (replace void with int!! static int Main(string[] args))
            //foreach (string arg in args)
            //{
            //    Console.WriteLine("Argument: {0}", arg);
            //}

            // When you run a C# program from the command line, you can provide additional information
            // after the program name
            // For example: MyProgram.exe arg1 arg2 arg3
            // In this case, arg1, arg2, and arg3 are command-line arguments

            Console.WriteLine("----------- EXAMPLE 5 - Data Types -----------");
            Console.Write("First name: ");
            string firstName = Console.ReadLine();  // declare the variable and store the input from the keyboard
            Console.WriteLine("");

            DateTime currentTime = DateTime.Now;
            Console.WriteLine("Hello {0}! Today is {1}.", firstName, currentTime);

            var isNight = false;
            if (DateTime.Now.Hour >= 18 || DateTime.Now.Hour < 6)
            {
                isNight = true;
            }
            Console.WriteLine("Night? " + isNight);
            Console.ReadLine();

            Console.WriteLine("----------- EXAMPLE 6 - Working with Strings -----------");
            string s1 = "abc";
            string s2 = s1;

            Console.WriteLine("s1: {0}, s2: {1}", s1, s2);
            //s1 = "ba";
            s1 = s1.Replace("abc", "ba");
            Console.WriteLine("s1: {0}, s2: {1}", s1, s2);

            // In C#, string and String are equivalent and can be used interchangeably
            // string is simply an alias for the System.String class in the .NET Framework

            String s3 = "abc";
            String s4 = s3;
            Console.WriteLine("s3: {0}, s4: {1}", s3, s4);
            s3 += "d";
            Console.WriteLine("s3: {0}, s4: {1}", s3, s4);

            // Strings are immutable
            // Once you create a string object with a specific value, you cannot directly
            // change the characters in that string
            // Any operation that seems to modify the string actually creates a new string object,
            // and the original string remains unchanged

            Console.WriteLine(Object.ReferenceEquals(s3, s4));  // check if two string variables
                                                                // reference the same object in memory

            // Even though s3 was modified, s4 still refers to the original, unmodified string = IMMUTABILITY

            Console.ReadLine();

            Console.WriteLine("----------- EXAMPLE 7 - operator== -----------");
            string a = "hello";
            string b = "h";
            b += "ello";    // append to contents of b

            var result1 = false;
            if (a == b)
            {
                result1 = true;
            }
            Console.WriteLine(result1);

            Console.WriteLine(a == b);  // will return true because operator == is overloaded for strings
                                        // to compare contents, not just memory references
            Console.WriteLine((object)a == b);  // will return false because the objects are different

            Console.ReadLine();

            Console.WriteLine("----------- EXAMPLE 8 - String Builder -----------");
            Console.WriteLine("StringBuilder Performance");

            const int noOfRepetitions = 60000;

            var regularString = string.Empty;   // ""

            // For a more precise measurement, use a performance counter instead of a Stopwatch
            var watch = Stopwatch.StartNew();
            for (var i = 0; i < noOfRepetitions; i++)
            {
                regularString += "a";
            }
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;

            Console.WriteLine("Using System.String: {0}ms", elapsedMs);

            var stringBuilder = new StringBuilder();

            watch = Stopwatch.StartNew();
            for (var i = 0; i < noOfRepetitions; i++)
            {
                stringBuilder.Append("a");
            }
            regularString = stringBuilder.ToString();
            watch.Stop();
            elapsedMs = watch.ElapsedMilliseconds;

            Console.WriteLine("Using System.Text.StringBuilder: {0}ms", elapsedMs);

            Console.ReadLine();

            Console.WriteLine("----------- EXAMPLE 9 - Working with Arrays -----------");
            // In C#, the base class for the System.Array class is System.Object
            // This means that all arrays in C# implicitly inherit from the System.Object class

            // Declaration + allocation
            int[] intArray;
            intArray = new int[3];  // all values will be 0

            // Declaration + assignment
            var doubleArray = new double[] { 34.23, 23.2 };
            var doubleArray1 = new[] { 34.23, 10.2, 23.2 };     // data type (double) is inferred

            // Accessing elements
            var arrayElement = doubleArray[0];
            doubleArray[1] = 5.55;

            for (var i = 0; i < intArray.Length; i++)
            {
                Console.WriteLine(intArray[i]);
            }

            // foreach
            foreach (var value in doubleArray)
            {
                Console.WriteLine(value);
            }

            // Other methods
            Array.Sort(doubleArray1);   // double implements IComparable<double>
            Console.WriteLine("Ascending - Sorted Array: ");
            foreach (var value in doubleArray1)
                Console.WriteLine(value);

            Console.WriteLine("Descending - Sorted Array: ");
            Array.Sort(doubleArray1);
            Array.Reverse(doubleArray1);
            foreach (var value in doubleArray1)
                Console.WriteLine(value);

            // for
            for (var i = 0; i < doubleArray.Length; i++)
                Console.WriteLine("doubleArray[{0}] = {1}", i, doubleArray[i]);

            Console.ReadLine();

            Console.WriteLine("----------- EXAMPLE 10 - Multidimensional Arrays -----------");

            // Declaration + allocation
            var cub = new int[5, 2, 7];     // declares and initializes a 3-dimensional array
                                            // with dimensions 5x2x7

            // Declaration + assignment of a 2-dimensional array - 2x4 with two rows and four columns
            var matrix = new[,]
            {
                { 4, 23, 5, 2 },
                { 1, 6, 13, 29 }
            };

            // for
            for (var i = 0; i < matrix.GetLength(0); i++) // iterates over the rows of the matrix array;
                                                          // matrix.GetLength(0) returns length of the first dimension (number of rows)
            {
                for (var j = 0; j < matrix.GetLength(1); j++) // iterates over the columns of the matrix array;
                                                              // matrix.GetLength(1) returns length of the second dimension (number of columns)
                    Console.Write(" {0}", matrix[i, j]); // prints each element of the array separated by a space.
                Console.WriteLine(); // moves to the next line to start a new row
            }
            Console.ReadLine();

            Console.WriteLine("----------- EXAMPLE 11 - Jagged Arrays -----------");
            // Matrice in trepte - each row can have a different length

            int[][] jaggedArray =
            {
                new int[] {0, 1, 2},  // define + initialize first row
                new int[] {3, 4},  // define + initialize second row
                new int[] {6, 7, 8, 9} // define + initialize third row
            };

            // Iterate through each row
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                // Iterate through each element within the current row
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    // Display the element
                    Console.Write(jaggedArray[i][j] + " ");
                }
                // New line after each row
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
