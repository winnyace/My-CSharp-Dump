string[] things = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };

foreach (var i in things)
{
    if (i.StartsWith("B"))
        Console.WriteLine(i);
}

// Below are some important things to keep in mind.
// int[] v = new int[3];
// for (int i = 0; i < 3; i++)
// {
//     v[i] = Convert.ToInt32(Console.ReadLine());
// }
//
// foreach (int n in v)
// {
//     Console.WriteLine(n);
// }
