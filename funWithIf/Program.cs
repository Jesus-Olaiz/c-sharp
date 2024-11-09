Random dice = new Random();

int roll1 = dice.Next(1,7);
int roll2 = dice.Next(1,7);
int roll3 = dice.Next(1,7);

int total = roll1 + roll2 + roll3;

Console.WriteLine($"You rolled a {roll1}, {roll2}, and a {roll3}\n");


if (roll1 == roll2 || roll2 == roll3 || roll1 == roll3)
{
    if (roll1 == roll2 && roll2 == roll3)
    {
        Console.WriteLine($"You somehow rolled all {roll1}'s! OOOOOO BABY A TRIPLE! cheater. You get an additional 6 points that you don't deserve.\n");

        total += 6;
    }
    else
    {
        Console.WriteLine("Aye! You got doubles! You cheated. Cheaty McCheatFace. You still get +2 to your total.\n");

        total += 2;

    }
}





Console.WriteLine($"Your total after three rolls isss: \n... {total}\n");


if (total >= 15)
{
    Console.WriteLine("You Win! nothing. You win nothing.");
}
else
{
    Console.WriteLine("You LOSE! Everything. you lost it all.");
}