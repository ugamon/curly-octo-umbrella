// See https://aka.ms/new-console-template for more information
using Game.Model;
using Quest.Domain;

using (var db = new GameDbContext())
{   
    var HeroAttribute1 = new  HeroAttribute(){
        Hp = 100.0,
        Exp = 0.0,
        Mana = 230.0,
    };

    db.HeroAttributes.Add(HeroAttribute1);
    db.SaveChanges();

}

using (var db = new GameDbContext())
{   
    var HeroAttribute2 = new  HeroAttribute(){
        Hp = 10.0,
        Exp = 0.0,
        Mana = 500.0,
    };

    db.HeroAttributes.Add(HeroAttribute2);
    db.SaveChanges();

}

using (var db = new GameDbContext())
{   
    var HeroAttribute3 = new  HeroAttribute(){
        Hp = 260.0,
        Exp = 0.0,
        Mana = 10.0,
    };

    db.HeroAttributes.Add(HeroAttribute3);
    db.SaveChanges();

}



using (var db = new GameDbContext())
{   
    var Heroes = db.HeroAttributes
        .Where(b => b.Hp > 10.0)
        .ToList();

    foreach(var hero in Heroes){
        Console.WriteLine($"recieved item: {hero}");
    }

}
