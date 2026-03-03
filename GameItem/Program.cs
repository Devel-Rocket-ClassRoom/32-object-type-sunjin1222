using System;

// README.md를 읽고 코드를 작성하세요.
class Item
{
    private string Name;

    private int Price;

    public void ToString()
    { 
    
    }

}

class Weapon : Item
{
    private int Damage;
    public void ToString()
    { 
    
    }
}
class Potion : Item
{
    private int HealAmount;
    public void ToString()
    { 
    
    }
}

class Inventory
{
     private object[] item=new object[10];


     public void AddItem(object item)
    {

    }
   

    public void ShowInventory()
    { 
    
    }

}



