using System.Runtime.CompilerServices;

public class Fighters
{
    public string name;
    public string choice;
    public bool isAlive;
    

    
    public int maxHealth;
    public int health;
    public int attack;

    
    

    public Fighters()
    {
        isAlive = true;
    }
    public bool getAlive()
    {
        return isAlive;
    }

    public void TakeAttack(int attack){
        this.attack += attack;
    }

    public void Fight(Enemy opp1)
    {
        Console.WriteLine($"you will fight against {opp1.name}");

        Console.WriteLine(this.name);
        
    }


   
}