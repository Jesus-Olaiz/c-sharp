Random rnd = new Random();

int firstVal = rnd.Next(1,1001);
int secondVal = rnd.Next(1,1001);

int biggestVal = Math.Max(firstVal,secondVal);

Console.WriteLine($"First Value : {firstVal} \nSecond Value : {secondVal}\n\n");
Console.WriteLine($"{biggestVal} is the BIGUN");