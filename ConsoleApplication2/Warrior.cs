using System;

namespace ConsoleApplication2
{
    public class Warrior
    {
        public Warrior enemy;

        public int hitPoint = 20;

        private Staty _stayte = new Staty();

        protected Random rnd = new Random();

        public virtual void AttackEnemy()
        {
            var tipeAttack = _stayte.GetListActiveAbility();

            if (rnd.Next(0, 10) > 7)
            {
                _stayte.GoToDefense();
            }
            else
            {
                enemy.GetDamage(tipeAttack[rnd.Next(tipeAttack.Count)]);
            }            
            
            
        }

        public void GetDamage(string type)
        {
            var damage = enemy._stayte.Attack(type);
            var damageAndType = _stayte.GetHit(damage.Item1, damage.Item2);
            _stayte = damageAndType.Item2;
            hitPoint -= damageAndType.Item1;
            if (hitPoint <= 0)
            {
                //умер
            }
        }
        
    }
    
    
    
}