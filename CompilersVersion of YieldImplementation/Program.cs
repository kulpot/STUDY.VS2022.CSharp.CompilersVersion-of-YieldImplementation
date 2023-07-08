using System;
using System.Collections.Generic;

//ref link:https://www.youtube.com/watch?v=qwKfjgI3Zsg&list=PL9B5E4C37F7B234A8&index=9
// with .net reflector

class MainClass
{
    static IEnumerable<int> GetRandomNumbers()
    {
        yield return 9;
        yield return 2;
        Console.WriteLine("hello, blowing up");
        if(new Random().Next() == 8)
            throw new Exception("Kaboom");
        yield return 5;
    }
    static void Main() { }
}