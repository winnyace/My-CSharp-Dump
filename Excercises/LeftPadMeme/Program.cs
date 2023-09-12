static string LeftPad(string input, int num, char ch)
{
    string output = "";
    while (num != 0)
    {
        output += ch.ToString();
        num--;
    }
    output += input;
    return output;
}

Console.WriteLine(LeftPad("Test", 5, ' '));
