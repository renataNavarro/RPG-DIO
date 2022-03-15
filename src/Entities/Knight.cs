using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RPGProject.src.Entities
{
    public class Knight:Hero
    {
         public Knight(string Name, int Level, string HeroType, int AttackForce, int HP)
       {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.AttackForce = AttackForce;
            this.HP = HP;
       }
        public override int Attack()
        {
            return AttackForce;
            //this.Name + " Atacou com sua espada";
        }
        public int Attack(int bonus){
            return AttackForce;
            //this.Name + " Atacou com bonus de ataque de " + bonus;
        }
           public override bool GetDamage(int damageAmount){
            
            return base.GetDamage(damageAmount);
        }
    }
}
