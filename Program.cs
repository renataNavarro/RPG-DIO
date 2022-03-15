using RPGProject.src.Entities;


Hero[] heroes = new Hero[]{
new Wizard("Lia", 10, "Mage", 30, 120),
new Knight("White Knight", 20, "Knight", 25, 150)
};

Hero currentHero;

ChooseHero();
void ChooseHero(){
Console.WriteLine("Escolha um Herói para o Duelo");
for(int i = 0; i < heroes.Length; i++){
    Console.WriteLine($"[{i}] {heroes[i].ToString()}");
}

try{
int userChoice = int.Parse(Console.ReadLine());
SetCurrentHero(userChoice);
}
catch{
Console.WriteLine("Digite um número válido");
ChooseHero();
}
}


void SetCurrentHero(int heroIndex){
if(heroIndex <= heroes.Length){
        Console.WriteLine("Escolheu o Herói: " + heroes[heroIndex].Name);
        currentHero = heroes[heroIndex];
        Battle battle = new Battle(currentHero, heroes);
        battle.BattleSetup();
       
    }
    else{
    Console.WriteLine("Personagem não encontrado! Digite um número válido.");
    ChooseHero();
      
}
}
