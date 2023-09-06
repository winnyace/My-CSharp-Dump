Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0; // Not sure what the fuck does this do. Maybe I missed something.

if (daysUntilExpiration <= 10)
{
    Console.WriteLine("Your subscription will expire soon. Renew now!");
}
else if (daysUntilExpiration <= 5)
{
    Console.WriteLine($"Your subscription will expire in {daysUntilExpiration} days.");
    Console.WriteLine("Renew new and save 10%");
}
else if (daysUntilExpiration <= 1)
{
    Console.WriteLine($"Your subscription will expire within a day");
    Console.WriteLine("Renew new and save 20%");
}
else
{
    Console.WriteLine("Your subscription has expired.");
}
