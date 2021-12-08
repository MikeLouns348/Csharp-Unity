using System;
using System.Collections.Generic;



class Program
{
    static void Main()
    {
        //ARRAYS

        //int[] numArray = new int[5];
        //numArray[0] = 5;
        //numArray[1] = 2;
        //numArray[2] = 10;
        //numArray[3] = 200;
        //numArray[4] = 5000;

        //int[] numArray1 = new int[] { 5, 2, 10, 200, 5000 };

        //int[] numArray2 = { 5, 2, 10, 200, 5000 };

        //numArray2[3] = 200000;

        //Console.WriteLine(numArray2[3]);
        //Console.ReadLine();

        //LISTS

        //List<int> intList = new List<int>();
        //intList.Add(4);
        //intList.Add(10);
        //intList.Remove(10);

        List<string> intList = new List<string>();
        intList.Add("Hello");
        intList.Add("Jesse");
        intList.Remove("James");

        Console.WriteLine(intList[0]);
        Console.ReadLine();
    }
}

