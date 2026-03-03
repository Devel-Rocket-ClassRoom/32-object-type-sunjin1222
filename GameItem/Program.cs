using System;


Console.WriteLine("=== 인벤토리 시스템 테스트 ===\n");

Weapon sword = new Weapon("불꽃 검", 500, 25);
Weapon bow = new Weapon("얼음 활", 450, 20);
Potion hpPotion = new Potion("체력 물약", 50, 100);
Potion mpPotion = new Potion("마나 물약", 80, 50);
Potion mpPotion2= new Potion("고급마나 물약", 120, 150);
Weapon Hammer = new Weapon("얼음 망치", 850, 100);

Inventory inventory = new Inventory();

inventory.AddItem(sword);
inventory.AddItem(bow);
inventory.AddItem(hpPotion);
inventory.AddItem(mpPotion);
inventory.AddItem(mpPotion2);
inventory.AddItem(mpPotion2);
inventory.AddItem(Hammer);

Console.WriteLine("[인벤토리 내용]");
inventory.ShowInventory();

Console.WriteLine("=== 타입 확인 테스트 ===");

Console.WriteLine($"sword의 타입: {sword.GetType().Name}");
Console.WriteLine($"sword.GetType() == typeof(Weapon): {sword.GetType() == typeof(Weapon)}");
Console.WriteLine($"sword.GetType() == typeof(Item): {sword.GetType() == typeof(Item)}");
Console.WriteLine($"sword is Item: {sword is Item}");

class Item
{
    public string Name;

    public int Price; 

    public Item(string name, int price)
    {
        Name = name;
        Price = price;
    }

    public override string ToString()
    {
        return $"Item {{ Name = {Name}, Price = {Price}}}";
    }
}

class Weapon : Item
{
    public int Damage;

    public Weapon(string name, int price, int damage): base(name, price)
    {
        Damage = damage;
    }

    public override string ToString()
    {
        return $"Weapon Name = {{{Name}, Price = {Price}, Damage = {Damage}}}";
    }
}

class Potion : Item
{
    public int HealAmount;

    public Potion(string name, int price, int healAmount) : base(name, price)
    {
        HealAmount = healAmount;
    }

    public override string ToString()
    {
        return $"Potion Name = {{{Name}, Price = {Price}, HealAmount = {HealAmount}}} ";
    }
}

class Inventory
{
    private object[] items = new object[10];
    private int index = 0;

    public void AddItem(object item)
    {
        if (index < items.Length)
        {
            items[index] = item;
            index++;
        }
        else
        {
            Console.WriteLine("인벤토리가 가득 찼습니다.");
        }
    }

    public void ShowInventory()
    {
        for (int i = 0; i < index; i++)
        {
            object item = items[i];
            Console.WriteLine($"슬롯 {i + 1}: {item} [{item.GetType().Name}]");
        }
    }
}


  
