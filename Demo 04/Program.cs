using System.ComponentModel;

namespace Demo_04
{
    //// 1. Class     -> Functions
    //// 2. Struct    -> Functions
    //// 3. Interface -> Functions
    //// 4. Enum

    //class NewData
    //{
    //    public int Sum;
    //    public int Mul;
    //}
    internal class Program
    {

        #region Function Prototype

        //static void PrintShape()
        //{
        //    // Body
        //    for (int i = 0; i < 10; i++)
        //    {
        //        Console.WriteLine("^_^");
        //    }
        //}

        //static void PrintShape(string Pattern = "f_f", int Count = 5)
        //{
        //    // Body
        //    for (int i = 0; i < Count; i++)
        //    {
        //        Console.WriteLine(Pattern);
        //    }
        //}

        //static int SumNumbers(int Num1,  int Num2)
        //{
        //    return Num1 + Num2;
        //} 

        #endregion

        #region Passing Value Type Parameters
        //static void SWAP(int X, int Y)
        //{
        //    int Temp = X;
        //    X = Y;
        //    Y = Temp;

        //}static void SWAP(ref int X, ref int Y)
        //{
        //    int Temp = X;
        //    X = Y;
        //    Y = Temp;
        //} 
        #endregion

        #region Passing Reference Type Parameters
        //static int SumArray(int[] Arr)
        //{
        //    int Sum = 0;

        //    Arr[0] = 100;

        //    for (int i = 0; i < Arr.Length; i++)
        //    {
        //        Sum += Arr[i];
        //    }

        //    return Sum;
        //}
        //static int SumArray(ref int[] Arr)
        //{
        //    int Sum = 0;

        //    Arr[0] = 100;

        //    for (int i = 0; i < Arr.Length; i++)
        //    {
        //        Sum += Arr[i];
        //    }

        //    return Sum;
        //}

        //static int SumArray(int[] Arr)
        //{
        //    int Sum = 0;

        //    Arr = new int[] { 4, 5, 6 };

        //    for (int i = 0; i < Arr.Length; i++)
        //    {
        //        Sum += Arr[i];
        //    }

        //    return Sum;
        //}

        //static int SumArray(ref int[] Arr)
        //{
        //    int Sum = 0;

        //    Arr = new int[] { 4, 5, 6 };

        //    for (int i = 0; i < Arr.Length; i++)
        //    {
        //        Sum += Arr[i];
        //    }

        //    return Sum;
        //} 
        #endregion

        #region Passing By Out
        //static int[] SumMul(int X,  int Y)
        //{
        //    int[] Result = { X + Y, X * Y };
        //    return Result;
        //}

        //static NewData SumMul (int X,  int Y)
        //{
        //    NewData data = new NewData();

        //    data.Sum = X + Y;
        //    data.Mul = X * Y;

        //    return data;
        //}

        //static void SumMul (int X,  int Y, out int Sum, out int Mul)
        //{
        //    Sum = X + Y;
        //    Mul = X * Y;
        //} 
        #endregion

        #region Params
        //static int SumArray(params int[] Arr)
        //{
        //    int Sum = 0;
        //    for (int i = 0; i < Arr.Length; i++)
        //    {
        //        Sum += Arr[i];
        //    }
        //    return Sum;
        //} 
        #endregion

        // Entery point
        static void Main(string[] args)
        {
            #region Array

            #region One D Array
            //int[] Numbers;
            //// Declare For Reference (Pointer) From Type 'Array of Integers'
            //// Numbers : Can refer to an object of the type 'Array of Integers'
            //// Numbers : Refer to Null

            //// 8 Bytes Will be allocated at stack for the reference 'Numbers'
            //// 0 Bytes Will be allocated at heap

            ////Numbers = new int[Size];
            //Numbers = new int[5];
            //// new 
            //// 1. Allocate The Number of Required Bytes For The Object At HEAP (4 Bytes * 5)
            //// 2. Initialize The Allocated Bytes With The Default Value of DataTypes
            //// 3. Call User-Defined Constructor if exists
            //// 4. Assign The Object To The Reference 'Numbers'

            ////Numbers[0] = 12;
            ////Numbers[1] = 6;
            ////Numbers[2] = 7;
            ////Numbers[3] = 8;
            ////Numbers[4] = 19;
            //////Numebers[5] = 20; // Out OF Range

            ////Console.WriteLine(Numbers[0]);
            ////Console.WriteLine(Numbers[1]);
            ////Console.WriteLine(Numbers[2]);
            ////Console.WriteLine(Numbers[3]);
            ////Console.WriteLine(Numbers[4]);

            ////int[] Numbers01 = { 1, 2, 3, 4, 5, 6, 7, 8 };
            ////int[] Numbers02 = new int[4] { 1, 2, 3, 4 };
            ////int[] Numbers03 = new int[6] { 1, 2, 3, 4, 0, 0 };
            ////int[] Numbers04 = new int[6];

            ////for (int i = 0; i < Numbers.Length; i++)
            ////{
            ////    Console.Write($"Enter Numbers[{i}]: ");
            ////    Numbers[i] = int.Parse( Console.ReadLine() );
            ////}

            ////Console.WriteLine("=============================");

            ////for (int i = 0;i < Numbers.Length;i++)
            ////{
            ////    Console.Write($"{Numbers[i]} ");
            ////}

            ////// One D Array
            ////Console.WriteLine(Numbers.Length); // Size
            ////Console.WriteLine(Numbers.Rank); // Dimension 
            #endregion

            #region Two D Array

            //int[,] Marks = new int[3, 3];
            //Marks [0, 0] = 99;
            //Marks [0, 1] = 98;
            //Marks [0, 2] = 95;

            //Marks [1, 0] = 100;
            //Marks [1, 1] = 88;
            //Marks [1, 2] = 92;

            //Marks [2, 0] = 94;
            //Marks [2, 1] = 82;
            //Marks [2, 2] = 89;

            //Console.WriteLine(Marks[0, 0]);
            //Console.WriteLine(Marks[0, 1]);
            //Console.WriteLine(Marks[0, 2]);

            //Console.WriteLine(Marks[1, 0]);
            //Console.WriteLine(Marks[1, 1]);
            //Console.WriteLine(Marks[1, 2]);

            //Console.WriteLine(Marks[2, 0]);
            //Console.WriteLine(Marks[2, 1]);
            //Console.WriteLine(Marks[2, 2]);

            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write($"Enter Marks[{i}, {j}] : ");
            //        Marks[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}

            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write($"{Marks[i,j]} ");
            //    }
            //    Console.WriteLine();
            //}



            #endregion

            #region Jagged Array

            //int[][] Marks = new int[3][];

            //Marks[0] = new int[2];
            //Marks[1] = new int[5];
            //Marks[2] = new int[1];

            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < Marks[i].Length; j++)
            //    {
            //        Console.Write($"Marks[{i}][{j}] : ");
            //        Marks[i][j] = int.Parse(Console.ReadLine());    
            //    }
            //}

            //Console.WriteLine("=================================");

            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < Marks[i].Length; j++)
            //    {
            //        Console.WriteLine(Marks[i][j]);
            //    }
            //}


            #endregion

            #endregion

            #region Functions

            #region Function Prototype

            //// Functions : block of code that have name
            //// U need to call the function in order to execute it 
            //// DRY

            //// Function Prototype
            //// 1. Signature
            //// 1.1 name
            //// 1.2 Return Type
            //// 1.3 Parameters (Inputs)
            ////2. Body

            //// Calling For Function
            //PrintShape(5, "T_T"); // Passing By Position/Order
            //PrintShape(Pattern: "-_-", Count: 10); // Passing By Name
            //PrintShape("x_x");
            //PrintShape();

            //// Methods
            //// 1. Class Member Methods (static method)
            //// 2. Object Member Methods (nonstatic method)

            //Console.WriteLine(SumNumbers(5,10)); 

            #endregion

            #region Passing Value Type Parameters

            #region Passing By Value

            // 1. Passing By Value

            //int A = 4 , B = 5;

            //Console.WriteLine($"A : {A}"); // 4
            //Console.WriteLine($"B : {B}"); // 5

            //Console.WriteLine("========= After Swap =========");

            ////SWAP(4, 5); // Passing By Value
            //SWAP(A, B); // Passing By Value

            //Console.WriteLine($"A : {A}"); // 4
            //Console.WriteLine($"B : {B}"); // 5



            #endregion

            #region Passing By Reference

            // 2. Passing By Reference

            //int A = 4, B = 5;

            //Console.WriteLine($"A : {A}"); // 4
            //Console.WriteLine($"B : {B}"); // 5

            //Console.WriteLine("========= After Swap =========");

            ////SWAP(4, 5); // Passing By Value
            //SWAP(ref A, ref B); // Passing By Value

            //Console.WriteLine($"A : {A}"); // 5
            //Console.WriteLine($"B : {B}"); // 4

            #endregion

            #endregion

            #region Passing Reference Type Parameters

            #region EX01

            #region Passing By Value

            //int[] Numbers = { 1, 2, 3 };

            //int Result = SumArray(Numbers); // Passing By Value (the value is an address)

            //Console.WriteLine(Result);
            //Console.WriteLine(Numbers[0]);

            #endregion

            #region Passing By Reference

            //int[] Numbers = { 1, 2, 3 };

            //int Result = SumArray(ref Numbers); // Passing By Reference 

            //Console.WriteLine(Result);
            //Console.WriteLine(Numbers[0]);

            #endregion

            #endregion

            #region EX02

            #region Passing By Value

            //int[] Numbers = { 1, 2, 3 };

            //Console.WriteLine(SumArray(Numbers)); // Passing By Value
            //Console.WriteLine(Numbers[0]); // 1

            #endregion

            #region Passing By Reference

            //int[] Numbers = { 1, 2, 3 };

            //Console.WriteLine(SumArray(ref Numbers)); // Passing By Ref
            //Console.WriteLine(Numbers[0]); // 4

            #endregion

            #endregion

            #endregion

            #region Passing By Out

            //int A = 3, B = 5;

            //int[] Result = SumMul(A, B);

            //Console.WriteLine(Result[0]);
            //Console.WriteLine(Result[1]);

            //int A = 3, B = 5;

            //NewData Result = SumMul(A, B);

            //Console.WriteLine(Result.Mul);
            //Console.WriteLine(Result.Sum);




            //int A = 4 , B = 5;

            //SumMul(A, B, out int Sum , out int Mul);
            ////SumMul(A, B, out int Sum , out int _);

            //Console.WriteLine(Sum);
            //Console.WriteLine(Mul);

            //// Passing By Value => Input Parameter
            //// Passing By Ref => Input & Output Parameter
            //// Passing By Out => Output Parameter

            #endregion

            #region Params

            //int[] Numbers = { 1, 3, 5, 7, 9, 11 };

            //Console.WriteLine(SumArray(Numbers));
            //Console.WriteLine(SumArray( 1, 3, 5, 7, 9, 11 ));

            #endregion

            #endregion

        }
    }
}
