using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RPGProject.src.Entities
{
    public class Wizard : Hero
    {
       public Wizard(string Name, int Level, string HeroType, int AttackForce, int HP)
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
            //this.Name + " Lançou magia";
        }
        public int Attack(int bonus){
            return AttackForce;
            // if(bonus > 6){
            //     return this.Name + " Lançou uma magia super efetiva com bonus de " + bonus;
            // }else{
            //     return this.Name + " Lançou uma magia fraca com bonus de " + bonus;
            // }
        }
        public override bool GetDamage(int damageAmount){
            
            return base.GetDamage(damageAmount);
        }
    }
}