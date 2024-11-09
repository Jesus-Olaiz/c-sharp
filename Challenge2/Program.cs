Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

// Your code goes here

if(daysUntilExpiration == 0){

    Console.WriteLine("Your subscription is over. It's gone. good job... \n\n\n.... i hate you..");

} else if (daysUntilExpiration == 1){

    Console.WriteLine($"Your subscription expires within a day!! A DAY LEFT BEFORE IT'S OVER!!");
    discountPercentage = 20;
    
} else if(daysUntilExpiration <= 5){

    Console.WriteLine($"Your subscription is going to DIE in {daysUntilExpiration} days.");
    discountPercentage = 10;

} else if(daysUntilExpiration <= 10){

    Console.WriteLine("Your subscription will expire soon. Renew now! \n\n\n.... if you even care.");

}

if(discountPercentage > 0){

    Console.WriteLine($"I will give you {discountPercentage}% off if you do something about it.");
    
}