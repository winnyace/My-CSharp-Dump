var rand = new Random();
int coin = rand.Next(2);
Console.WriteLine($"{(coin == 0 ? "Tails" : "Heads")}");
