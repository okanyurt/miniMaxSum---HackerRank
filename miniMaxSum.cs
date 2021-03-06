
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;
using System.Numerics;

class Result
{

    /*
     * Complete the 'miniMaxSum' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void miniMaxSum(List<int> arr)
    {
       int sayac = arr.Count();
       List<int> Result =new List<int>();
       arr.Sort();
       
       int minum = arr.Min();
       int maxim=arr.Max();
       BigInteger  toplam=0;
       for(int i=0;i<sayac;i++)
       {
           toplam =toplam+arr[i];
       }
       Console.Write(toplam-maxim);
       Console.Write(' ');
       Console.Write(toplam-minum);
    }

}

class Solution
{
    public static void Main(string[] args)
    {

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.miniMaxSum(arr);
    }
}
