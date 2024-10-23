using Microsoft.SqlServer.Server;
using System.Collections.Generic;
using System;

{
    Console.Write($"{GREEN}" + id + $"{NORMAL} ");
}
Console.WriteLine();
        }



        static void FindCommonElement()
{
    int[] dataset1 = { 1, 2, 3, 4, 5 };
    int[] dataset2 = { 3, 4, 5, 6, 7 };

    HashSet<int> set1 = new HashSet<int>(dataset1);
    HashSet<int> set2 = new HashSet<int>(dataset2);

    set1.IntersectWith(set2);

    Console.Write($"{RED}Program 10 :-{NORMAL}{CYAN} Common elements:");
    foreach (int element in set1)
    {
        Console.Write($"{GREEN}" + element + $"{NORMAL}");
    }
    Console.WriteLine();
}

    }
}