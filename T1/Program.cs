using System;
using System.Collections;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;

namespace T1
{
    class Program
    {
        static void Main(string[] args)
        {
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

            //int[] arrrr = new int[3];

            //arrrr[0] = 12;
            //arrrr[1] = 15;
            //arrrr[2] = 17;

            //DateTime StartTime;
            //TimeSpan endtime;
            //StartTime = DateTime.Now;      
            //DisplayNums(arrrr);
            //endtime = DateTime.Now.Subtract(StartTime);

            //Console.WriteLine("{0},{1}",StartTime.ToString(),endtime);

            //Console.ReadLine();

            #endregion

            //----------------------------- Chapter 2 - Arrays and ArrayLists ------------------------------------

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

            ArrayList Greads = new ArrayList();
            Greads.Add(22);
            Greads.Add(30);
            Greads.Add(216);
            Greads.Add(1327);

            int position;

            position = Greads.Add(90);
            Console.WriteLine(position.ToString());

            foreach (var item in Greads)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("---------------------------------------");
            Greads.Insert(1,23);

            foreach (var item in Greads)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Capasity : {0}, Count : {1}",Greads.Capacity,Greads.Count);

            Console.WriteLine("---------------------------------------");
            ArrayList getrange = new ArrayList();

            getrange = Greads.GetRange(2, 2);
            foreach (var item in getrange)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("---------------------------------------");
            int[] Nameee;
            Nameee = Greads.ToArray();
            Console.ReadLine();
            #endregion

        }




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
        //static void DisplayNums( int[] arr)
        //{
        //    for (int i = 0; i < arr.GetUpperBound(0); i++)
        //    {
        //        Console.Write(arr[i]+"");
        //    }


        //}
        #endregion

        //----------------------------- Chapter 2 - Arrays and ArrayLists ------------------------------------

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
    }
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





}
