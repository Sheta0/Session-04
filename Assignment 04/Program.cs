using System;
using System.Numerics;
using System.Xml;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment_04
{
    class Students
    {
        public int Mark;
    }

    internal class Program
    {
        #region Q1
        //static int SquareByValue(int Num)
        //{
        //    Num *= Num;
        //    return Num;
        //}

        //static int SquareByRef(ref int Num)
        //{
        //    Num *= Num;
        //    return Num;
        //} 
        #endregion

        #region Q2

        //static int DecrementByValue(Students Student)
        //{
        //    Student.Mark--;
        //    Student = new Students();
        //    Student.Mark = 90;

        //    return Student.Mark;
        //}
        //static int DecrementByRef(ref Students Student)
        //{
        //    Student.Mark--;
        //    Student = new Students();
        //    Student.Mark = 90;

        //    return Student.Mark;
        //}

        #endregion

        #region Q3

        //static void SumAndSub (int Num01, int Num02, out int Sum, out int Sub)
        //{
        //    Sum = Num01 + Num02;
        //    Sub = Num01 - Num02;
        //}

        #endregion

        #region Q4

        //static int SumOfDigits(int Number)
        //{
        //    int sum = 0;

        //    string NumString = Number.ToString();

        //    foreach (char Digit in NumString)
        //    {
        //        sum += int.Parse(Digit.ToString());
        //    }

        //    return sum;
        //}

        #endregion

        #region Q5

        //static bool IsPrime(int Number)
        //{
        //    if (Number <= 1) 
        //        return false;

        //    for (int i = 2; i <= Math.Sqrt(Number); i++) 
        //    {
        //        if (Number % i == 0)
        //            return false;
        //    }

        //    return true;
        //}

        #endregion

        #region Q6

        //static void MinMaxArray(int[] Nums, ref int Min, ref int Max)
        //{
        //    Min = Nums[0];
        //    Max = Nums[0];
        //    for (int i = 0; i < Nums.Length; i++)
        //    {
        //        if (Nums[i] < Min)
        //        {
        //            Min = Nums[i];
        //        }
        //        if (Nums[i] > Max)
        //        {
        //            Max = Nums[i];
        //        }
        //    }
        //}

        #endregion

        #region Q7

        //static int Factorial(int Num)
        //{
        //    int result = 1;

        //    for (int i = 1; i <= Num; i++)
        //    {
        //        result *= i;
        //    }

        //    return result;
        //}

        #endregion

        #region Q8

        //static string ChangeChar(string Text, int Position, char NewChar)
        //{
        //    if(Position < 0 || Position>= Text.Length)
        //    {
        //        Console.WriteLine("Position out of range");
        //        return Text;
        //    }

        //    char[] CharArray = Text.ToCharArray();

        //    CharArray[Position] = NewChar;

        //    string NewText = new string(CharArray);   

        //    return NewText;
        //}

        #endregion

        static void Main(string[] args)
        {
            #region Q1

            // Passing Value Types by Value :-
            // A copy of the value type variables are passed to the method stack frame
            // When changes happen to the parameters it only affects the values in the method stack frame
            // The original value in main method stack frame doesn't change

            // Passing Value Types By Refernce :- 
            // The address of the value is passed to the method
            // no parameters are stored in the method stack frame
            // the original values names are changed to alias names which are the parameter names
            // changes happen directly to the original values
            // then the names go back to the original Names 

            //int Number = 5;

            //// Passing By Value

            //Console.WriteLine($"Before SquareByValue = {Number}"); // 5
            //Console.WriteLine($"SquareByValue = {SquareByValue(Number)}"); // 25 
            //Console.WriteLine($"After SquareByValue = {Number}");  // 5

            //Console.WriteLine("===================================");

            //// Passing By Reference

            //Console.WriteLine($"Before SquareByRef = {Number}"); // 5
            //Console.WriteLine($"SquareByRef = {SquareByRef(ref Number)}"); // 25
            //Console.WriteLine($"After SquareByRef = {Number}"); // 25

            #endregion

            #region Q2

            //// Passing Reference Type By Value :- 
            //// A copy of the reference is passed to the method 
            //// the copied reference points to the same object in memory (heap)
            //// changes to the object data affect the original object because both references point to the same object in heap
            //// Reassigning the reference only affects the local reference in the method
            //// the original reference in the main method does not change

            //// Passing Reference Type By Reference :-
            //// No new reference is created in the method's stack frame
            //// the method directly uses the original reference
            //// the original References names are changed to alias names which are the parameter names
            //// Changes to the object data affect the original object because both references point to the same object in heap
            //// Reassigning the reference changes the original reference in the main method so it points  to a new object
            //// then the names go back to the original Names 
            //Students Std = new Students();
            //Std.Mark = 100;

            //// Passing By Value

            //Console.WriteLine($"Before DecrementByValue = {Std.Mark}"); // 100
            //Console.WriteLine($"DecrementByValue = {DecrementByValue(Std)}"); // 90
            //Console.WriteLine($"After DecrementByValue = {Std.Mark}");  // 99

            //Console.WriteLine("===================================");

            ////// Passing By Reference

            //Std.Mark = 100;

            //Console.WriteLine($"Before DecrementByRef = {Std.Mark}"); // 100
            //Console.WriteLine($"DecrementByRef = {DecrementByRef(ref Std)}"); // 90
            //Console.WriteLine($"After DecrementByRef = {Std.Mark}");  // 90

            #endregion

            #region Q3

            //int Number1, Number2;

            //do
            //{
            //    Console.Write("Enter the first number : ");
            //} while (!int.TryParse(Console.ReadLine(), out Number1));

            //do
            //{
            //    Console.Write("Enter the second number : ");
            //} while (!int.TryParse(Console.ReadLine(), out Number2));

            //SumAndSub(Number1, Number2, out int Sum, out int Sub);

            //Console.WriteLine($"Sum = {Sum}");
            //Console.WriteLine($"Sub = {Sub}");



            #endregion

            #region Q4

            //int Number;
            //do
            //{
            //    Console.Write("Enter a number : ");
            //}
            //while (!int.TryParse(Console.ReadLine(), out Number));

            //int Result = SumOfDigits(Number);

            //Console.WriteLine($"Sum of digits = {Result}");

            #endregion

            #region Q5

            //int Number = 13;

            //Console.WriteLine(IsPrime(Number));

            #endregion

            #region Q6

            //int[] Nums = { 5, 6, 8, 9, 10, 11, 12, 13, 40, 10 };

            //int Min = 0;
            //int Max = 0;

            //MinMaxArray(Nums, ref Min, ref Max);

            //Console.WriteLine($"Minimum =  {Min}");
            //Console.WriteLine($"Maximum =  {Max}");

            #endregion

            #region Q7

            //int Number;
            //do
            //{
            //    Console.WriteLine("Enter a number : ");
            //}
            //while (!int.TryParse(Console.ReadLine(), out Number));

            //int Result = Factorial(Number);

            //Console.WriteLine($"{ Number}! = {Result}");

            #endregion

            #region Q8

            //string Text = "NewJeans";

            //string NewText = ChangeChar(Text, 7, 'Z');

            //Console.WriteLine(Text);
            //Console.WriteLine(NewText);

            #endregion

            #region Q9

            //int Size;

            //do
            //{
            //    Console.Write("Enter the size of the matrix : ");
            //}
            //while (!int.TryParse(Console.ReadLine(), out Size) || Size <= 0);

            //for (int i = 0; i < Size; i++)
            //{
            //    for (int j = 0; j < Size; j++)
            //    {
            //        if (i == j)
            //            Console.Write("1 ");
            //        else
            //            Console.Write("0 ");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region Q10

            //int[] Arr = { 1, 2, 3, 4, 5, 6 };
            //int Sum = 0;

            //foreach (int num in Arr)
            //{
            //    Sum += num;
            //}

            //Console.WriteLine($"Sum = {Sum}");

            #endregion

            #region Q11

            //int[] Arr01 = { 1, 2, 9, 15, 54, 5, 3 };
            //int[] Arr02 = { 10, 8, 20, 4, 6, 7, 31 };

            //int[] MergedArray = new int[Arr01.Length * 2];

            //Array.Copy(Arr01, 0, MergedArray, 0, Arr01.Length);
            //Array.Copy(Arr02, 0, MergedArray, Arr01.Length, Arr02.Length);

            //Array.Sort(MergedArray);

            //foreach (int i in MergedArray)
            //{
            //    Console.Write($"{i} ");
            //}

            #endregion

            #region Q12

            //int[] Arr = { 1, 2, 1, 3, 2, 2 };

            //Array.Sort(Arr);

            //int Count = 1;
            //for (int i = 0; i < Arr.Length; i++)
            //{
            //    if (i < Arr.Length - 1 && Arr[i] == Arr[i + 1])
            //    {
            //        Count++;
            //    }
            //    else
            //    {
            //        Console.WriteLine($"Number {Arr[i]} : {Count}");
            //        Count = 1;
            //    }
            //}
            #endregion

            #region Q13

            //int[] Numbers = { 21, 12, 5, 8, 91 };
            //int Max = Numbers[0];
            //int Min = Numbers[0];
            //for (int i = 0; i < Numbers.Length; i++)
            //{
            //    if (Numbers[i] > Max)
            //        Max = Numbers[i];

            //    if (Numbers[i] < Min)
            //        Min = Numbers[i];

            //}
            //Console.WriteLine(Max);
            //Console.WriteLine(Min);

            #endregion

            #region Q14

            //int[] Numbers = { 21, 12, 5, 32, 91 };

            //int Max = Numbers[0];
            //int SecondLargest = Numbers[0];

            //for (int i = 1; i < Numbers.Length; i++)
            //{
            //    if (Numbers[i] > Max)
            //    {
            //        SecondLargest = Max;
            //        Max = Numbers[i];
            //    } else if (Numbers[i] > SecondLargest && Numbers[i] != Max) 
            //        SecondLargest = Numbers[i];
            //}

            //Console.WriteLine(Max);

            //Console.WriteLine(SecondLargest);
            #endregion

            #region Q15

            //int ArrLength;
            //do
            //{
            //    Console.Write("Enter The Array length : ");
            //} while (!int.TryParse(Console.ReadLine(), out ArrLength));

            //int[] Numbers = new int[ArrLength];

            //Console.WriteLine("=============================");

            //for (int i = 0; i < ArrLength; i++)
            //{
            //    do
            //    {
            //        Console.Write($"Numbers[{i + 1}] :  ");
            //    } while (!int.TryParse(Console.ReadLine(), out Numbers[i]));
            //}

            //int MaxDistance= 0, Number = 0, FirstInstance= 0, LastInstance = 0;

            //for (int i = 0; i < Numbers.Length; i++)
            //{
            //    for (int j = Numbers.Length - 1; j > i; j--)
            //    {
            //        if (Numbers[i] == Numbers[j])
            //        {
            //            if (j - i - 1 > MaxDistance)
            //            {
            //                MaxDistance = j - i - 1;
            //                Number = Numbers[i];
            //                FirstInstance = i + 1;
            //                LastInstance = j + 1;
            //                break;
            //            }
            //        }
            //    }
            //}

            //Console.WriteLine("=============================");

            //Console.WriteLine($"The longest distance is between Number {Number} in cell {FirstInstance} and cell {LastInstance}  = {MaxDistance}");

            #endregion

            #region Q16

            //string Text;
            //do
            //{
            //    Console.Write("Enter your string: ");
            //    Text = Console.ReadLine();
            //} while (string.IsNullOrWhiteSpace(Text));

            //Console.WriteLine(string.Join(" ", Text.Split(' ').Reverse()));

            #endregion

            #region Q17

            //int Rows;
            //do
            //{
            //    Console.Write("Enter the number of rows : ");
            //} while (!int.TryParse(Console.ReadLine(), out Rows) || Rows <= 0);

            //int Cols;
            //do
            //{
            //    Console.Write("Enter the number of columns : ");
            //} while (!int.TryParse(Console.ReadLine(), out Cols) || Cols <= 0);

            //int[,] FirstArray = new int[Rows, Cols];
            //int[,] SecondArray = new int[Rows, Cols];

            //Console.WriteLine("=========================================");

            //Console.WriteLine("Enter the First Array : ");

            //for (int i = 0; i < Rows; i++)
            //{
            //    for (int j = 0; j < Cols; j++)
            //    {
            //        do
            //        {
            //            Console.Write($"FirstArray [{i},{j}]: ");
            //        } while (!int.TryParse(Console.ReadLine(), out FirstArray[i, j]));
            //    }
            //}

            //for (int i = 0; i < Rows; i++)
            //{
            //    for (int j = 0; j < Cols; j++)
            //    {
            //        SecondArray[i, j] = FirstArray[i, j];
            //    }
            //}

            //Console.WriteLine("=========================================");

            //Console.WriteLine("The second array is:");
            //for (int i = 0; i < Rows; i++)
            //{
            //    for (int j = 0; j < Cols; j++)
            //    {
            //        Console.Write(SecondArray[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region Q18

            //int ArrLength;
            //do
            //{
            //    Console.Write("Enter The Array length : ");
            //} while (!int.TryParse(Console.ReadLine(), out ArrLength));

            //int[] Numbers = new int[ArrLength];

            //Console.WriteLine("=============================");

            //for (int i = 0; i < ArrLength; i++)
            //{
            //    do
            //    {
            //        Console.Write($"Numbers[{i}] :  ");
            //    } while (!int.TryParse(Console.ReadLine(), out Numbers[i]));
            //}

            //Console.WriteLine("=============================");

            //for (int i = Numbers.Length - 1 ; i >= 0 ; i--)
            //{
            //    Console.Write($"{Numbers[i]} ");
            //}

            #endregion

            #region TASK

            //int Rows;
            //do
            //{
            //    Console.Write("Enter the number of rows : ");

            //}
            //while (!int.TryParse(Console.ReadLine(), out Rows));

            //int Cols;
            //do
            //{
            //    Console.Write("Enter the number of columns : ");

            //}
            //while (!int.TryParse(Console.ReadLine(), out Cols));

            //int[,] Marks = new int[Rows, Cols];


            //for (int i = 0; i < Rows; i++)
            //{
            //    for (int j = 0; j < Cols; j++)
            //    {
            //        do
            //        {
            //            Console.Write($"Enter Marks[{i}, {j}] : ");
            //        }
            //        while (!int.TryParse(Console.ReadLine(), out Marks[i,j]));
            //    }
            //}

            //Console.WriteLine();

            //for (int i = 0; i < Marks.Length; i++)
            //{
            //    Console.WriteLine(Marks[i/Marks.GetLength(1), i%Marks.GetLength(1)]);
            //}

            #endregion
        }
    }
}