public class Shop
{

    public Weapons selectedWeapon;
    public List<Weapons> weapons = new List<Weapons>()
{
    new Weapons{name="Sword", power = 30, price = 30},
    new Weapons{name="chainsaw", power = 50, price = 50},
    new Weapons{name="DEATH REAPER", power = 70, price = 100},
    new Weapons{name="gun", power = 100, price = 70}
    
};


public void BuyItem()
{
    Console.WriteLine("What item would you like to buy?");
    Console.WriteLine("Sword");
    Console.WriteLine("2. Chainsaw");
    Console.WriteLine("DEATH REAPER");
    Console.WriteLine("gun");
    string weaponval;
    int WV;
    weaponval = Console.ReadLine();
    int.TryParse(weaponval, out WV);
    if(WV >= 1 && WV <= 4)
    {
        
    for (int i = 0; i < 4; i++)
    {
        if (i-1 == WV)
        {
            selectedWeapon = weapons[i-2];
            Console.WriteLine($"You bought a {selectedWeapon.name} with power {selectedWeapon.power}");
            
            
        }
    }
    }

    
   
}
}