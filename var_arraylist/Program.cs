using System;
using System.Collections;
ArrayList ab = new ArrayList();
//arrarylist is a dynamic array that can store elements of different type, (ab)is the class name

//adds various elements to the "ab" ArrayList
ab.Add("1");
ab.Add("Bill");
ab.Add(" ");
ab.Add(true);
ab.Add(4.5);
ab.Add(null);

//var is used here because it adapts to whatever type 
foreach(var item in ab)
{
    Console.Write(item + " ,");
}