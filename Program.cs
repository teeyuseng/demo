using System;
class P
{
    static ConsoleColor the_original_F = Console.ForegroundColor;
    static void Main(string[] args)
    {
        int x = -86;
        Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$");
        Console.Write("原為 ");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(x);
        Console.ForegroundColor = the_original_F;
        //  fix #1 觀察下面註解的語法
        /* 讓 x 變數存個
        0 或 1
        的值 */
        x = (int)(new Random().NextDouble() * 2);
        Console.WriteLine("?????????????????????????");
        Console.Write("後來為 ");
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine(x);
        Console.ForegroundColor = the_original_F;
        Console.WriteLine("#########################");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
    }
}

