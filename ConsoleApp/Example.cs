using System;
class BigDick
{
    static void Main()
    {
        Random rnd = new Random();
        int i;
        for (i = 0; i < 50; i++)
        {
            int a = rnd.Next(1, 20);
            if ((a % 3 == 0) && (a % 5 == 0)) Console.WriteLine("Число " + a + " is a BigDick");
            else if (a % 3 == 0) Console.WriteLine("Число " + a + " is a Big");
            else if (a % 5 == 0) Console.WriteLine("Число " + a + " is a Dick");
        }
    }
}