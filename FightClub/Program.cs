Fighters player = new();

List<Enemy> enemies = new();
Random generator = new Random();
enemies.Add(new BabyGronk());
enemies.Add(new KaiCenat());
Shop shop = new();


Console.WriteLine("What is your name?");
player.name = Console.ReadLine();
while (player.getAlive() == true)
{
    Console.WriteLine("Do you want to:");
    Console.WriteLine("1. ");
    Console.WriteLine("2. ");
    Console.WriteLine("3. ");
    Console.WriteLine("4. Fight");
    player.choice = Console.ReadLine();
   
    if (player.choice == "1")
    {

    }
  
    if (player.choice == "2")
    {
        
    }
  
    if (player.choice == "3")
    {
        shop.BuyItem();
        
       
    }
 
    if (player.choice == "4")
    {
        Console.WriteLine("You want to fight");
        Enemy opp = enemies[generator.Next(enemies.Count)];
        player.Fight(opp);
        Console.ReadLine();

    }


}

