
using System.ComponentModel;


public class Weapons{

   public string name;
   public int power;
    public float price;


    public class ItemInfo : Weapons{

        public List<Weapons> artillery = new();
        public ItemInfo(){
            
        }
    }

    
}

