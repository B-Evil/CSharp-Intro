using System;

namespace OurCompany.LearnCoding.OOP.Games;
public class GameApp{
    public static void Main(string[] args){
        //creat player
        GameEntity[] entity = new GameEntity[5];
        entity[0] = new Player("Nó cego", 10, 100);
        entity[1] = new Enimy("Goblin", 5, 10);
        entity[2] = new Enimy("Knight", 15, 27);
        entity[3] = new Enimy("Vampire", 5, 50);
        entity[4] = new Enimy("Demon", 10, 35);

        int turn = 0; 
        Player player = (Player) entity[0];
        int aliveEnimys = entity.Length -1; // Enimys - player = 4
        int enimyCount = 1;

        while(player.Islive && aliveEnimys > 0){
            turn++;
            Console.WriteLine("");
            Console.WriteLine($"Rodada: {turn}");
            Console.WriteLine("".PadLeft(100,'-'));
            Random random = new Random();

            // bug de lógica na parte de verificação se há algum enimy vivo
            for (int i = enimyCount; i < entity.Length; i++){
                Enimy enimy = (Enimy) entity[i];
                if(!enimy.Islive){
                    enimyCount++;
                    aliveEnimys--;
                } else {
                    Console.WriteLine("");
                    Console.WriteLine($"Enimy: {enimy.Type}");
                    enimy.Log();
                    enimy.TakeDamage(random.Next(0, player.Damage + 1));
                    if(player.Islive){
                        Console.WriteLine($"Hero: {player.Name}");
                        if(enimy.Islive){
                            player.Log();
                            player.TakeDamage(random.Next(0, enimy.Damage + 1));
                        }
                    }
                    if(!player.Islive){break;}
                }
            }
        }
        Console.WriteLine("".PadLeft(100, '='));
        Console.WriteLine($"Game turns: {turn}");
        if(player.Islive){
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

interface ILogger {
    void Log();
}

interface IDamageable{
    void TakeDamage(int value);
}

public class GameEntity : IDamageable, ILogger{
    public int HP {get; set;}
    public int Damage {get; set;}
    public bool Islive {get => HP > 0;}

    public GameEntity(int damage, int hp){
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
        if(HP <= 0){
            Console.WriteLine(" - [Dead]");
        }else {
            Console.WriteLine(" - [Alive]");
        }
    }
}

public class Player : GameEntity{
    public string Name { get; set; }
    public Player(string name, int damage, int hp):base(damage, hp){
        Name = name;
    }

    public override void TakeDamage(int damage){
        base.TakeDamage(damage);
        Console.Write($"[Combat] => Hero: [{Name}] - Hit: [{damage}] Damage - ");
        base.Log();
    }

    public override void Log(){
        Console.Write($"[Hero] => {Name} - ");
        base.Log();
    } 
}

public class Enimy : GameEntity{
    public string Type { get; set; }
    public Enimy(string name, int damage, int hp):base(damage, hp){
        Type = name; 
    }    

    public override void Log(){
        Console.Write($"[Monster] => {Type} - ");
        base.Log();
    }

    public override void TakeDamage(int damage){
        base.TakeDamage(damage);
        Console.Write($"[Combat] => Monster: [{Type}] - Hit: [{damage}] Damage - ");
        base.Log();
    }
}