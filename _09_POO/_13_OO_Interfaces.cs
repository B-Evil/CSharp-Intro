using System;
using System.ComponentModel;
using System.Data;
using System.Net.Http;
using System.Reflection.Metadata.Ecma335;
/*
# An interface is a contract that specifies a set of methods
  and properties that a class must implement.
# Interfaces are used to achieve abstraction by allowing to write
  code that is independent of any specific implementation.
# Interfaces are declared using the interface keyword,
  followed by the name of the interface and a set of
  method and property signatures.
# A class can implement one or more interfaces by providing
  an implementation for each method and property in the interface.
# A class can inherit from a base class and implement one or
  more interfaces at the same time.
# Interfaces can be used to define common functionality across
  multiple classes, which can help reduce code duplication and
  improve maintainability.
# Interfaces can be used as Types

# Class Content
  # Theory
  # Explain the classes and interfaces
  # Show the entire program
  # Run the game
  # Change the game a little to execute multiple times and 
    count victories
*/
namespace OurCompany.LearnCoding.OOP.Interface;

public class GameApp{
    public static void Main(string[] args){
        GameEntity[] entity = new GameEntity[5];
        entity[0] = new Player("Evil", 100, 10);
        entity[1] = new Enimy("Goblin", 10, 5);
        entity[2] = new Enimy("Knight",30, 15);
        entity[3] = new Enimy("Vampire", 50, 5);
        entity[4] = new Enimy("Demon", 35, 10);

        int turn = 0;
        Random random = new Random(); 
        Player player = (Player) entity[0];
        int aliveEnimys = entity.Length -1; // -> 4

        while(player.IsLive && aliveEnimys > 0){
            turn++;
            Console.WriteLine("".PadLeft(100, '-'));
            Console.WriteLine($"Turn: {turn}");

            for (int i = 1; i < entity.Length; i++){
                Enimy enimy = (Enimy) entity[i];
                if (!enimy.IsLive) {
                    aliveEnimys--;
                } else {
                    enimy.Log();
                    enimy.TakeDamage(random.Next(0, player.Damage + 1));
                    if(enimy.IsLive){
                        player.Log();
                        player.TakeDamage(random.Next(0, enimy.Damage + 1));
                    }

                    if(!player.IsLive){
                        break;
                    }
                }
            }
        }

        Console.WriteLine("".PadLeft(100, '='));
        Console.WriteLine($"Game turns: {turn}");
        if(player.IsLive){
            Console.WriteLine("Player Won!!");
        }else{
            Console.WriteLine("Player Lost!!"); 
        }

        player.Log(); 
        for (int i = 0 ; i < entity.Length; i++){
            ILogger logger = entity[i];
            logger.Log();
        }
        Console.WriteLine("".PadLeft(100, '='));
    }
}

interface ILogger{
    void Log();
}
interface IDamageable{
    void TakeDamage(int value); 
}

public class GameEntity : IDamageable, ILogger{
    public int HP {get; set;}
    public int Damage {get; set;}
    public bool IsLive {get => HP > 0;}

    public GameEntity(int hp, int damage){
        HP = hp;
        Damage = damage;
    }
    public virtual void TakeDamage(int damage){
        HP -= damage; 
        if(HP <= 0){
            HP = 0;
        }
    }
    public virtual void Log(){
        Console.Write($"HP: [{HP}]");
        if(IsLive){
            Console.WriteLine(" - [Alive]");
        } else {
            Console.WriteLine("[Dead]");
        }
    }
}

public class Enimy : GameEntity{
    public string Type {get; set;}

    public Enimy(string name, int hp, int damage):base(hp, damage){
        Type = name;
    }
    public override void TakeDamage(int damage){
        base.TakeDamage(damage);
        Console.Write($"[Combat] Monster:[{Type}] - took: [{damage}] Damage - ");
        Log();
    }
    public override void Log(){
        Console.Write($"Monster: [{Type}] - ");
        base.Log();
    }
}

public class Player : GameEntity{
    public string Name {get; set;}
    public Player(string name, int hp, int damage):base(hp, damage){
        Name = name;
    }
    public override void TakeDamage(int damage){
        base.TakeDamage(damage);
        Console.Write($"[Combat] Hero:[{Name}] - took: [{damage}] Damage - ");
        Log();
    }
    public override void Log(){
        Console.Write($"Hero: [{Name}]");
        base.Log();
    }
}