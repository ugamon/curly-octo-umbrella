// See https://aka.ms/new-console-template for more information
using Quest.Domain;

var myActiveHero = new Person(35, "John", new Archer(), new ArcherAttributes());




Console.BackgroundColor = ConsoleColor.Cyan;
Console.Clear();
Console.ForegroundColor = ConsoleColor.Yellow;



myActiveHero.Shout();
Console.WriteLine(myActiveHero.Attributes.HP);