using RPGProject.src.Entities;

public class Battle{

    Hero currentHero;
    Hero opponent;
    Hero[] heroes;


public Battle(Hero currentHero, Hero[] heroes){
    this.currentHero = currentHero;
    this.heroes = heroes;
}
public void BattleSetup(){
    opponent = GetOpponent();
    Console.WriteLine("O seu oponente será: " + opponent.ToString());
    
    Console.WriteLine("Pressione [Enter] para começar a batalha e atacar");
    Console.ReadKey();
    StartBattle();

}
Hero GetOpponent(){

    bool uniqueHero = false;
    Hero hero = new Hero();

    while(!uniqueHero){
        Random rand = new Random();
         hero = heroes[rand.Next(heroes.Length)];
        if(hero != currentHero)
        {
            uniqueHero = true;
            
        }
    }

    return hero;

    
}

void StartBattle(){
bool heroIsAlive = true;
bool opponentIsAlive = true;

while(heroIsAlive || opponentIsAlive){
    Console.WriteLine("Aperte [Enter] para iniciar turno");
    Console.ReadKey();
   int damage = currentHero.Attack();
    opponentIsAlive = opponent.GetDamage(damage);
    Console.WriteLine($"{opponent.Name} recebeu um ataque de {damage}");
    damage = opponent.Attack();
    heroIsAlive = currentHero.GetDamage(damage);
    Console.WriteLine($"{currentHero.Name} recebeu um ataque de {damage}");
}
if(heroIsAlive && !opponentIsAlive){
    Console.WriteLine("Você ganhou!");
}else if(!heroIsAlive && opponentIsAlive){
    Console.WriteLine("Você perdeu!");
}else if(!heroIsAlive && !opponentIsAlive){
    Console.WriteLine("Ambos morreram durante a batalha!");
}
Console.WriteLine("Aperte [Enter] para finalizar");
Console.ReadKey();
}
}
