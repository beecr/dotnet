﻿
Console.WriteLine("Enter the price:");

int price = Convert.ToInt32(Console.ReadLine());



if (price<15)
{
    Console.WriteLine("Buy Now");
}
else if (price >=15 && price <18)
{
    Console.WriteLine("Do Bargain!");
}
else if (price >= 18 && price < 20)
{
    Console.WriteLine("Think about it!");
}
else
{
    Console.WriteLine("Dont Buy");
}