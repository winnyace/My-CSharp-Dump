// I like doing these small little programs that do simple things. This is a simple number reversing and palimdrome checking program.

int input, num = 0, copy;

Console.WriteLine("Please give me a number. I will reverse it and tell you if it is a palimdrome or not.");
input = Convert.ToInt32(Console.ReadLine());
copy = input;

Console.Write($"The palidrome of {input} is ");
while (input != 0)
{
    num = num * 10 + input % 10;
    input /= 10;
}
Console.Write($"{num}\n");

if (copy == num)
{
    Console.WriteLine("The number is a palimdrome.");
}
else
{
    Console.WriteLine("The number is not a palimdrome.");
}
