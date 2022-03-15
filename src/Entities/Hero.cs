using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RPGProject.src.Entities
{
    public class Hero
    {
        public Hero(string Name, int Level, string HeroType, int AttackForce, int HP)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.AttackForce = AttackForce;
            this.HP = HP;
        }

        public Hero(){
            this.Name = "Unknown";
            this.Level = 0;
            this.HeroType = "Hero";
            this.AttackForce = 50;
            this.HP = 100;

        }

        public override string ToString()
        {
            return $"Nome: {Name}, Level: {Level}, Tipo: {HeroType}, Força de Ataque: {AttackForce}, HP: {HP}";
        }

        public virtual int Attack(){
            return AttackForce;
        }

        public virtual bool GetDamage(int damageAmount){
           this.HP -= damageAmount;
            if(HP <= 0)
            {
                HP = 0;
                return false;
            }else
            {
                return true;
            }
        }
        public string Name;
        public int Level;
        public string HeroType;
        public int AttackForce;
        public int HP;

    }
}