
public class Enemy : Fighters
{
    public List<string> opp1 = new();
}



public class BabyGronk : Enemy
{
    public BabyGronk()
    {
        name = "Baby Gronk";
        health = 100;
        

        
    }
}

public class KaiCenat : Enemy
{
    public KaiCenat()
    {
        name = "Kai Cenat";
        health = 100;
    }
}