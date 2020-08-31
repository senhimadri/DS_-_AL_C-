using System;
using System.Collections;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;
using System.Globalization;

namespace T1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Chapter 1 - An Introduction to Collections, Generics, and the Timing Class-----------------------------
            //****---------------------------Chapter 1 - An Introduction to Collections, Generics, and the Timing Class---------------****
            #region T1 Page-4
            //Name myName = new Name("Himadri", "Sen", "Apu");
            //string fullName, Inits;
            //fullName = myName.ToString();
            //Inits = myName.Initials();
            //Console.WriteLine("My name is {0}. {1}.", fullName, Inits);
            //Console.WriteLine("My initials is {0}.", Inits);
            //Console.ReadLine();
            #endregion
            #region T2 Page-6
            //int num;
            //string snum;
            //Console.Write("Enter a Number: ");
            //snum = Console.ReadLine();
            //num = Int32.Parse(snum);
            //Console.WriteLine(num);
            //Console.ReadLine();
            #endregion
            #region T3 Page-12 -Collection (ArrayList)

            //ArrayList Al = new ArrayList();
            //Console.WriteLine("Adding Some Numbers");
            //Al.Add(50);
            //Al.Add(60);
            //Al.Add(70);
            //Al.Add(80);
            //Al.Add(10);
            //Al.Add(20);
            //Al.Add(30);
            //Al.Add(40);

            //Console.WriteLine("Capasity: {0}", Al.Capacity);

            //Console.WriteLine("Count: {0}", Al.Count);

            //Console.Write("Content:");
            //foreach (int i in Al)
            //{
            //    Console.Write(i + "");
            //}
            //Console.WriteLine();
            //Console.Write("Sorted Content: ");

            //Al.Sort();
            //foreach (int i in Al)
            //{
            //    Console.Write(i + " ");
            //}
            //Console.WriteLine();
            //Console.ReadKey();

            #endregion
            #region T3 Pagge-12 -Collection (Hashtable)

            //Hashtable Ht = new Hashtable();

            //Ht.Add("001", "Himadri Sen Apu");
            //Ht.Add("002", "Joti Nag");
            //Ht.Add("003", "Tomojita Voj Tanmi");
            //Ht.Add("004", "Vishojit Ray Shoyon");
            //Ht.Add("005", "Hasan Badrick");

            //if (Ht.ContainsValue("Himadri Sen Apu"))
            //{
            //    Console.WriteLine("Himadri is available");
            //}
            //else
            //{
            //    Console.WriteLine("Himadri is unavailable");
            //}
            //Ht.Remove("001");

            //if (Ht.ContainsKey("001"))
            //{
            //    Console.WriteLine("Key");
            //}
            //else
            //{
            //    Console.WriteLine("Unkey");
            //}
            //Console.WriteLine();

            //Console.ReadLine();
            #endregion
            #region T3 Page-12 -Collection (SortedList)

            //SortedList Sl = new SortedList();
            //Sl.Add("001", "Himadri Sen Apu");
            //Sl.Add("002", "Joti Nag");
            //Sl.Add("003", "Tomojita Voj Tanmi");
            //Sl.Add("004", "Vishojit Ray Shoyon");
            //Sl.Add("005", "Hasan Badrick");

            //ICollection Keys = Sl.Keys;

            //ICollection Values = Sl.Values;

            //foreach (var item in Keys)
            //{
            //    Console.WriteLine(" {0}: {1}", item, Sl[item]);
            //}
            //foreach (var item in Values)
            //{
            //    Console.Write(Sl.IndexOfValue(item));
            //}
            //foreach (var item in Sl.GetValueList())
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine(Sl.IndexOfKey("003"));
            //Console.ReadLine();
            #endregion
            #region T3 Page-12 -Collection (Stack)
            //Stack St = new Stack();
            //St.Push('A');
            //St.Push('B');
            //St.Push('F');
            //St.Push('K');
            //St.Push('L');

            //Console.WriteLine("Current Stack");
            //foreach (Char C in St)
            //{
            //    Console.Write(C + " ");
            //}
            //Console.WriteLine();
            //St.Push('V');
            //St.Push('H');
            //Console.WriteLine("2nd Stack");
            //foreach (Char C in St)
            //{
            //    Console.Write(C + " ");
            //}
            //Console.WriteLine();
            //Console.WriteLine("The last poppable stack is {0}", St.Peek());
            //Console.WriteLine("Removing Values");
            //St.Pop();
            //Console.WriteLine("Stakes after removing:1 ");
            //foreach (Char C in St)
            //{
            //    Console.Write(C + " ");
            //}
            //Console.WriteLine();
            //St.Pop();
            //Console.WriteLine("Stakes after removing: 2 ");
            //foreach (Char C in St)
            //{
            //    Console.Write(C + " ");
            //}
            //Console.WriteLine();
            //St.Pop();
            //Console.WriteLine("Stakes after removing: 3");
            //foreach (Char C in St)
            //{
            //    Console.Write(C + " ");
            //}
            //Console.WriteLine();
            //Console.ReadLine();
            #endregion
            #region T3 Page-12 -Collection (Queue)
            //Queue Q = new Queue();
            //Q.Enqueue('S');
            //Q.Enqueue('L');
            //Q.Enqueue('K');
            //Q.Enqueue('T');
            //Q.Enqueue('P');
            //Q.Enqueue('D');
            //Console.WriteLine("Current Queue");
            //foreach (Char item in Q)
            //{
            //    Console.Write(item + " ");
            //}
            //Console.WriteLine();
            //Q.Enqueue('V');
            //Q.Enqueue('H');
            //Console.WriteLine("Queue After Adding");
            //foreach (char item in Q)
            //{
            //    Console.Write(item + " ");
            //}
            //Console.WriteLine();
            //Console.WriteLine("Removing some values ");
            //Q.Dequeue();
            //Console.WriteLine("Queue After Removing");
            //foreach (char item in Q)
            //{
            //    Console.Write(item + " ");
            //}
            //Console.WriteLine();
            //char Ch = (char)Q.Dequeue();
            //Console.WriteLine("Queue After Removing 2");
            //foreach (char item in Q)
            //{
            //    Console.Write(item + " ");
            //}
            //Console.WriteLine();
            //Console.WriteLine("Removed Value {0}", Ch);
            //Console.ReadLine();
            #endregion
            #region T3 Page-12 -Collection (BitArray)

            ////Creating 2 BitArray of Size 8
            //BitArray Ba1 = new BitArray(8);
            //BitArray Ba2 = new BitArray(8);

            //byte[] a = { 60 };
            //byte[] b = { 13 };

            //Ba1 = new BitArray(a);
            //Ba2 = new BitArray(b);

            //Console.WriteLine("BitArray Ba1: 60");

            //for (int i = 0; i < Ba1.Count; i++)
            //{
            //    Console.WriteLine("{0,-6}", Ba2[i]);
            //}
            //Console.WriteLine();

            //Console.WriteLine("Bit array ba2: 13");

            //Console.ReadLine();
            #endregion
            #region T4 Page-15 - Generic

            //MyGenericArray<int> intArray = new MyGenericArray<int>(5);

            //for (int c = 0; c < 5; c++)
            //{
            //    intArray.setItem(c, c * 5);
            //}
            //for (int c = 0; c < 5; c++)
            //{
            //    Console.Write(intArray.getItem(c) + " ");
            //}
            //Console.WriteLine();
            //MyGenericArray<char> charArray = new MyGenericArray<char>(5);
            //for (int c = 0; c < 5; c++)
            //{
            //    charArray.setItem(c, (char)(c + 97));
            //}
            //for (int c = 0; c < 5; c++)
            //{
            //    Console.Write(charArray.getItem(c));
            //}
            //Console.WriteLine();

            //Console.ReadLine();
            #endregion
            #region T4 Page-15 Generic (Methods)
            //int Num1 = 100;
            //int Num2 = 200;
            //Console.WriteLine("Num 1: " + Num1);
            //Console.WriteLine("Num 2: " + Num2);

            //Swap<int>(ref Num1, ref Num2);

            //Console.WriteLine("Num 1: " + Num1);
            //Console.WriteLine("Num 2: " + Num2);

            //string Str1 = "Rohim";
            //string Str2 = "Karim";

            //Console.WriteLine("String 1: " + Str1);
            //Console.WriteLine("String 2: " + Str2);

            //Swap<string>(ref Str1, ref Str2);

            //Console.WriteLine("String 1: " + Str1);
            //Console.WriteLine("String 2: " + Str2);
            //Console.ReadLine();
            #endregion
            #region T4 Page-15 - Generic  (Class)

            //Node<string> node1 = new Node<string>("Mike", null);
            //Node<string> node2 = new Node<string>("Raymond", node1);

            #endregion
            #region Generic (Methods YouTube Video)
            ////Link: https://www.youtube.com/watch?v=jb0G6FM3-6Y&t=891s

            //int[] Number = new int[3];

            //Number[0] = 10;
            //Number[1] = 20;
            //Number[2] = 30;

            //string[] Name = new string[3];

            //Name[0] = "Himadri Sen Apu";
            //Name[1] = "Joti Nag";
            //Name[2] = "Nobonita Voj Tanmmi";

            //GenericExample.ShowArray(Number);
            //GenericExample.ShowArray(Name);


            //Console.ReadLine();
            #endregion
            #region T4 Page- 15 Generic (class YouTube Video)
            ////Link: https://www.youtube.com/watch?v=LRUKsUAGwts

            //GenericExample<int> genericExample = new GenericExample<int>(20);
            //Console.WriteLine("Print Int= {0}", genericExample.Getbox());

            //GenericExample<string> genericExample1 = new GenericExample<string>("Himadri Sen Apu");
            //Console.WriteLine("Print String= {0}", genericExample1.Getbox());

            //Console.ReadLine();
            #endregion
            #region TimingTest
            //int[] arrrr = new int[]{2,5,8,3,6};

            //DateTime StartTime;
            //TimeSpan endtime;
            //StartTime = DateTime.Now;
            //DisplayNums(arrrr);
            //endtime = DateTime.Now.Subtract(StartTime);
            //GC.Collect();
            //Console.WriteLine("{0},{1}", StartTime.ToString(), endtime);

            //Console.ReadLine();

            #endregion
            #region Page 19 - Collect()
            //// Link : https://docs.microsoft.com/en-us/dotnet/api/system.gc.collect?view=netcore-3.1#:~:text=It%20performs%20a%20blocking%20garbage,maximum%20amount%20of%20available%20memory.
            //// Put some objects in memory.
            //_GarbadgeClass _garbadgeClass = new _GarbadgeClass();
            //_garbadgeClass.MakeSomeGarbadge();

            //Console.WriteLine("Memory Used Before Collection {0:N0}", GC.GetTotalMemory(false));
            //// Collect all generations of memory.
            //GC.Collect();
            //Console.WriteLine("Memory used before Collection {0:N0}", GC.GetTotalMemory(true));
            ////------------------------------------------------------------------------------------------------

            //// Determine the maximum number of generations the system garbage collector currently supports.
            //Console.WriteLine("The Height Generation is : {0}", GC.MaxGeneration);

            //// Determine which generation myGCCol object is stored in.
            //Console.WriteLine("The Generation : {0}", GC.GetGeneration(_garbadgeClass));

            //// Determine the best available approximation of the number of bytes currently allocated in managed memory.
            //Console.WriteLine("Total Memory:  : {0}", GC.GetTotalMemory(false));
            //// Perform a collection of generation 0 only.

            //GC.Collect(0);
            //// Determine which generation myGCCol object is stored in.
            //Console.WriteLine("The Generation : {0}", GC.GetGeneration(_garbadgeClass));

            //// Determine the best available approximation of the number of bytes currently allocated in managed memory.
            //Console.WriteLine("Total Memory:  : {0}", GC.GetTotalMemory(false));

            //GC.Collect(0);
            //// Determine which generation myGCCol object is stored in.
            //Console.WriteLine("The Generation : {0}", GC.GetGeneration(_garbadgeClass));

            //// Determine the best available approximation of the number of bytes currently allocated in managed memory.
            //Console.WriteLine("Total Memory:  : {0}", GC.GetTotalMemory(false));

            //Console.ReadLine();
            #endregion
            #region Page 18 Timming Test for the .NET Environment 
            //int[] nums = new int[100000];
            //BuildArray(nums);
            //TimeSpan StartTime;
            //TimeSpan Duration;
            //StartTime = Process.GetCurrentProcess().Threads[0].UserProcessorTime;
            //DisplayNums(nums);
            //Duration = Process.GetCurrentProcess().Threads[0].UserProcessorTime.Subtract(StartTime);
            //Console.WriteLine("Starttime: {0}, Duration : {1}", StartTime, Duration.TotalSeconds);
            //Console.ReadLine();
            #endregion
            #region Page 21- A Timing Test Class
            //int[] nums = new int[100000];
            //BuildArray(nums);
            //Timing Tobj = new Timing();
            //Tobj.StartTime();
            //DisplayNums(nums);
            //Tobj._StopTime();
            //Console.WriteLine("Time (.NET): {0}", Tobj.Result().TotalSeconds);
            //Console.ReadLine();
            #endregion
            //---------------------------*****************************************************************************--------------------
            #endregion
            #region Chapter 2 - Arrays and ArrayLists-----------------------------------------------
            //--------------------------------------- Chapter 2 - Arrays and ArrayLists -----------------------------------
            #region Array Type
            //int[] number = new int[] {2,5,3,9,5,12};
            //Type arrayType = number.GetType();

            //if (arrayType.IsArray)
            //{
            //    Console.WriteLine("{0}",arrayType);
            //}
            //else
            //{
            //    Console.WriteLine("Not an Array");
            //}
            //Console.ReadLine();

            #endregion
            #region Multidimentional Array

            //int[,] Greade = new int[4,6];

            //int[,] gread = new int[,] { { 1,2,3,4,5 },
            //                            { 6,7,8,9,0 },
            //                            { 3,4,2,1,3 } };
            ////int Ans1 = gread[2,3];
            ////int Ans2 = gread.GetValue[1,1];
            //int last_gread = gread.GetUpperBound(1);
            //double average = 0.0;
            //int last_student = gread.GetUpperBound(0);
            //int total;
            //for (int row = 0; row <= last_student; row++)
            //{
            //    total = 0;
            //    for (int col = 0; col <= last_gread; col++)
            //    {
            //        total = total + gread[row, col];
            //        average = total / last_gread;

            //        Console.WriteLine("Average: {0},,, {1}" , average, total);
            //    }
            //}
            //Console.ReadLine();
            #endregion
            #region GetUpperBound & GetLowerBound

            //int[,,] arr = new int[2, 3, 4];

            //Console.WriteLine("Dinension 0 UpperBound : {0}", arr.GetUpperBound(0).ToString());
            //Console.WriteLine("Dinension 0 LowerBound : {0}", arr.GetLowerBound(0).ToString());

            //Console.WriteLine("Dinension 1 UpperBound : {0}", arr.GetUpperBound(1).ToString());
            //Console.WriteLine("Dinension 1 LowerBound : {0}", arr.GetLowerBound(1).ToString());

            //Console.WriteLine("Dinension 2 UpperBound : {0}", arr.GetUpperBound(2).ToString());
            //Console.WriteLine("Dinension 2 LowerBound : {0}", arr.GetLowerBound(2).ToString());

            //Console.ReadLine();
            #endregion
            #region Parameter Arrays --- Page 32

            //int[] arrr = new int[] { 1,2,3};
            //int aaa=Sumnums(arrr);

            //Console.WriteLine(aaa.ToString());
            //Console.ReadLine();
            #endregion
            #region Jagged Arrays --
            //int[][] source = new int[5][];

            //int[][] Sourse = new int[3][] { new int[] {3,6,8,2}, new int[] { 6, 3, 4, 5, 6 }, new int[] { 1,2,3,4,5,6} };

            //Console.WriteLine(Sourse.Length.ToString());


            //for (int i = 0; i < Sourse.Length; i++)
            //{
            //    for (int j = 0; j < GetColumnLength(Sourse, i); j++)
            //    {
            //        Console.Write(Sourse[i][j].ToString());
            //    }
            //    Console.WriteLine();
            //}
            //Console.ReadLine();
            #endregion
            #region Arraylist-------

            //ArrayList Greads = new ArrayList();
            //Greads.Add(22);
            //Greads.Add(30);
            //Greads.Add(216);
            //Greads.Add(1327);

            //int position;

            //position = Greads.Add(90);
            //Console.WriteLine(position.ToString());

            //foreach (var item in Greads)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("---------------------------------------");
            //Greads.Insert(1,23);

            //foreach (var item in Greads)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("---------------------------------------");
            //Console.WriteLine("Capasity : {0}, Count : {1}",Greads.Capacity,Greads.Count);

            //Console.WriteLine("---------------------------------------");
            //ArrayList getrange = new ArrayList();

            //getrange = Greads.GetRange(2, 2);
            //foreach (var item in getrange)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("---------------------------------------");
            //Console.ReadLine();
            #endregion
            //----------------------------------------------**************************-------------------------------------
            #endregion
            #region Chapter 3 - Basic Sorting Algorithms----------------------------------------------
            //-------------------------------------- Chapter 3 - Basic Sorting Algorithms -----------------------------------
            #region Page 43- An Array Class Test Bed   ------ Problom is not solved
            //CArray nums = new CArray(49);
            //for (int i = 0; i <= 49; i++)
            //    nums.Insert(i);
            //nums.DisplayElements();
            #endregion
            #region Page 45 -- Bubble Sort
            //int[] Arr = {78,26,53,60,48, 2,3,4,12,47,20,26,50 };
            //int Temp;
            //for (int i = 0; i < Arr.Length; i++)
            //{
            //    for (int j =0 ; j < Arr.Length-1; j++)
            //    {
            //        if (Arr[j]>Arr[j+1])
            //        {
            //            Temp = Arr[j + 1];
            //            Arr[j + 1] = Arr[j];
            //            Arr[j] = Temp;
            //        }
            //    }
            //}
            //for (int i = 0; i < Arr.Length; i++)
            //{
            //    Console.WriteLine(Arr[i].ToString());
            //}
            //Console.ReadLine();
            #endregion
            #region Page 48 Selection Sort
            //int[] Arr = new int[] { 4, 7, 5, 3, 9 };
            //int temp, Sm;
            //for (int i = 0; i < Arr.Length - 1; i++)
            //{
            //    Sm = i;
            //    for (int j = i + 1; j < Arr.Length; j++)
            //    {
            //        if (Arr[j] < Arr[Sm])
            //        {
            //            Sm = j;
            //        }
            //    }
            //    temp = Arr[Sm];
            //    Arr[Sm] = Arr[i];
            //    Arr[i] = temp;
            //}
            //for (int i = 0; i < Arr.Length; i++)
            //{
            //    Console.Write(Arr[i] + ",");
            //}
            //Console.ReadLine();
            #endregion
            #region Page 50 - Insertion Sort
            //int[] arr = new int[] {22,31,15,41,17};
            //int inner, temp;
            //for (int Outer= 0; Outer < arr.Length; Outer++)
            //{
            //    temp = arr[Outer];
            //    inner = Outer;
            //    while (inner>0 && arr[inner-1]>=temp)
            //    {
            //        arr[inner] = arr[inner - 1];
            //        inner -= 1;
            //    }
            //    arr[inner] = temp;
            //}
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write(arr[i]+",");
            //}
            //Console.ReadLine();
            #endregion
            #region Page 51 - Timming Comparisons of the Basic Sorting Algorithm

            #endregion
            //-----------------------------------------****************************-------------------------------------------
            #endregion
        }
        #region Chapter 1 - An Introduction to Collections, Generics, and the Timing Class
        //---------------------------Chapter 1 - An Introduction to Collections, Generics, and the Timing Class-----------
        #region T4 Page-15- Generic (Methods)
        //static void Swap<T>(ref T Val1, ref T Val2)
        //{
        //    T temp;
        //    temp = Val1;
        //    Val1 = Val2;
        //    Val2 = temp;
        //}
        #endregion
        #region Timing Test Page 17
        //static void DisplayNums(int[] arr)
        //{
        //    for (int i = 0; i < arr.GetUpperBound(0); i++)
        //    {
        //        Console.Write(arr[i] + "");
        //    }
        //}
        #endregion
        #region Page 51 - Timming Comparisons of the Basic Sorting Algorithms
        //static void BuildArray(int [] arr)
        //{
        //    for (int i = 0; i <= 99999; i++)
        //    {
        //        arr[i] = i;
        //    }
        //}
        //static void DisplayNums(int[] arr)
        //{
        //    for (int i = 0; i < arr.GetUpperBound(0); i++)
        //    {
        //        Console.Write(arr[i] + "");
        //    }
        //}
        #endregion
        #region Page 21 - A Timing Test Class
        //static void BuildArray(int[] arr)
        //{
        //    for (int i = 0; i <= 99999; i++)
        //    {
        //        arr[i] = i;
        //    }
        //}
        //static void DisplayNums(int[] arr)
        //{
        //    for (int i = 0; i < arr.GetUpperBound(0); i++)
        //    {
        //        Console.Write(arr[i] + "");
        //    }
        //}
        #endregion
        //----------------------------******************************************-----------------------------------------
        #endregion
        #region Chapter 2 - Arrays and ArrayLists
        //--------------------------------------- Chapter 2 - Arrays and ArrayLists ------------------------------------
        #region Parameter Arrays --- Page 32
        //static int Sumnums( params int [] nums)
        //{
        //    int sum = 0;
        //    for (int i = 0; i <= nums.GetUpperBound(0); i++)
        //    {
        //        sum = sum + nums[i];
        //    }
        //    return sum;
        //}
        #endregion
        #region Jagged Arrays ----Methods that return the length of any column of Jagged Array

        //public static int GetColumnLength(int[][] jaggedArray, int columnindex)
        //{
        //    int length = 0;
        //    foreach (var item in jaggedArray[columnindex])
        //    {
        //        length = length + 1;
        //    }
        //    return length;
        //}

        #endregion
        //--------------------------------------************************************-------------------------------------
        #endregion
        #region Chapter 3 - Basic Sorting Algorithms
        //-------------------------------------- Chapter 3 - Basic Sorting Algorithms -----------------------------------
        //--------------------------------------************************************-------------------------------------
        #endregion
    }
    #region Chapter 1 - An Introduction to Collections, Generics, and the Timing Class
    //---------------------------Chapter 1 - An Introduction to Collections, Generics, and the Timing Class-----------
    #region T1 Page-4
    //public struct Name
    //{
    //    private string fname, mname, lname;
    //    public Name(string first, string middle, string last)
    //    {
    //        fname = first;
    //        mname = middle;
    //        lname = last;
    //    }
    //    public string firstName
    //    {
    //        get
    //        {
    //            return fname;
    //        }
    //        set
    //        {
    //            fname = firstName;
    //        }
    //    }
    //    public string middleName
    //    {
    //        get
    //        {
    //            return mname;
    //        }
    //        set
    //        {
    //            mname = middleName;
    //        }
    //    }
    //    public string lastName
    //    {
    //        get
    //        {
    //            return lname;
    //        }
    //        set
    //        {
    //            lname = lastName;
    //        }
    //    }
    //    public override string ToString()
    //    {
    //        return (String.Format("{0} {1} {2}", fname, mname, lname));
    //    }
    //    public string Initials()
    //    {
    //        return (String.Format("{0}.{1}.{2}.", fname.Substring(0, 1), mname.Substring(0, 1), lname.Substring(0, 1)));
    //    }
    //}
    #endregion
    #region T4 Page-15 - Generic (Class)
    //public class Node<T>
    //{
    //    T data;
    //    Node<T> Link;
    //    public Node(T data, Node<T> Link)
    //    {
    //        this.data = data;
    //        this.Link = Link;
    //    }
    //}

    #endregion
    #region T4 Page- 15 - Generic (Methods YouTube Video)

    //Link: https://www.youtube.com/watch?v=jb0G6FM3-6Y&t=891s
    //class GenericExample
    //{
    //    public static void ShowArray<T>(T[] arr)
    //    {
    //        for (int i = 0; i < arr.Length; i++)
    //        {
    //            Console.WriteLine(arr[i]);
    //        }
    //    }
    //}
    #endregion
    #region T4 Page- 15 Generic (class YouTube Video)
    ////Link: https://www.youtube.com/watch?v=LRUKsUAGwts

    //class GenericExample<T>
    //{
    //    T Box;
    //    public GenericExample(T B)
    //    {
    //        this.Box = B;
    //    }
    //    public T Getbox()
    //    {
    //        return this.Box;
    //    }
    //}
    #endregion
    #region Page 19 Collect()
    //class _GarbadgeClass
    //{
    //    private const int MaxGarbadge = 1000;
    //    public void MakeSomeGarbadge()
    //    {
    //        Version Vt;
    //        // Create object and release them to fill up memory with unused object 
    //        for (int i = 0; i < MaxGarbadge; i++)
    //        {
    //            Vt = new Version();
    //        }
    //    }
    //}
    #endregion
    #region Page 21 - A Timing Test Class
    //public class Timing
    //{
    //    TimeSpan StartingTime;
    //    TimeSpan DurationTime;
    //    public Timing()
    //    {
    //        StartingTime = new TimeSpan(0);
    //        DurationTime = new TimeSpan(0);
    //    }
    //    public void _StopTime()
    //    {
    //        DurationTime = Process.GetCurrentProcess().Threads[0].UserProcessorTime.Subtract(StartingTime);
    //    }
    //    public void StartTime()
    //    {
    //        GC.Collect();
    //        GC.WaitForPendingFinalizers();
    //        StartingTime = Process.GetCurrentProcess().Threads[0].UserProcessorTime;
    //    }
    //    public TimeSpan Result()
    //    {
    //        return DurationTime;
    //    }
    //}
    #endregion
    //-------------------------------------*************************************-------------------------------
    #endregion
    #region Chapter 2 - Arrays and ArrayLists
    //--------------------------------------- Chapter 2 - Arrays and ArrayLists ------------------------------------
    //------------------------------------------*******************************-------------------------------------
    #endregion
    #region Chapter 3 - Basic Sorting Algorithms
    //-------------------------------------- Chapter 3 - Basic Sorting Algorithms -----------------------------------
    #region Page 43- An Array Class Test Bed
    //class CArray
    //{
    //    private int[] arr;
    //    private int upper;
    //    private int numElements;
    //    public CArray(int size)
    //    {
    //        arr = new int[size];
    //        upper = size - 1;
    //        numElements = 0;
    //    }
    //    public void Insert(int item)
    //    {
    //        arr[numElements] = item;
    //        numElements++;
    //    }
    //    public void DisplayElements()
    //    {
    //        for (int i = 0; i <= upper; i++)
    //            Console.Write(arr[i] + " ");
    //    }
    //    public void Clear()
    //    {
    //        for (int i = 0; i <= upper; i++)
    //            arr[i] = 0;
    //        numElements = 0;
    //    }
    //}
    #endregion
    //----------------------------------------********************************---------------------------------------
    #endregion
}