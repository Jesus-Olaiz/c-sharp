int heroHealth = 10;
int monsterHealth = 10;

Random monsterAttack = new Random();
Random heroAttack = new Random();

do
{

int heroAttackDmg = heroAttack.Next(1, 11);
int monsterAttackDmg = monsterAttack.Next(1,11);

monsterHealth -= heroAttackDmg;
Console.WriteLine($"The Hero hits the Monster for {heroAttackDmg} damage! The Monster is left with {monsterHealth} health\n");

if(monsterHealth > 0){
    heroHealth -= monsterAttackDmg;

    Console.WriteLine($"The Monster swings back! He hits the Hero for {monsterAttackDmg} damage! Our Hero has {heroHealth} health left!\n");
}

if(monsterHealth <= 0){
    Console.WriteLine("OUR HERO HAS PREVAILED!!!");
}
else if(heroHealth <=0){
    Console.WriteLine("OUR HERO HAS FALLEN! LETS GO GET THAT MONSTER!");
}


} while ((heroHealth > 0) && (monsterHealth > 0));
