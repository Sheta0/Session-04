using System.Xml;

namespace Assignment_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1

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

            #region Q2

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

            #region Q3

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

            #region Q4

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

            #region Q5

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

            #region Q6

            //string Text;
            //do
            //{
            //    Console.Write("Enter your string: ");
            //    Text = Console.ReadLine();
            //} while (string.IsNullOrWhiteSpace(Text));

            //Console.WriteLine(string.Join(" ", Text.Split(' ').Reverse()));

            #endregion

            #region Q7

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

            #region Q8

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
        }
    }
}