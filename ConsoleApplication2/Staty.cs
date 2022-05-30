using System;
using System.Collections.Generic;

namespace ConsoleApplication2
{
    public class Staty
    {
        protected Random rnd = new Random();
        
        public virtual  Tuple <int, Staty>  GetHit(int hit, Staty stay)
        {
            if (rnd.Next(0, 10) < 8)
                return Tuple.Create(hit, stay);
            return Tuple.Create(0, new Staty());
        }

        protected  Tuple<int, SandInEyes> SandAttack()
        {
            return Tuple.Create(1, new SandInEyes());
        }

        protected Tuple<int, StomachAche> HitInStomach()
        {
            return Tuple.Create(3, new StomachAche());
        }

        protected Tuple<int, HitRightHeand> HitOnLeftHeand()
        {
            return Tuple.Create(3, new HitRightHeand());       
        }

        protected Tuple<int, HitLeg> HitOnLeg()
        {
            return Tuple.Create(3, new HitLeg());
        }

        public Defense GoToDefense()
        {
            return new Defense();
        }

        public virtual List<string> GetListActiveAbility()
        {
            return new List<string> (new string[] {"SandAttack", "HitInStomach", "HitOnLeftHeand", "HitOnLeg"});
        }

        public virtual Tuple<int, Staty> Attack(string type)
        {
            return AttackSpal(type);
        }
        
        protected  Tuple<int, Staty> AttackSpal(string type)
        {
            try
            {
                if (!GetListActiveAbility().Contains(type))
                    throw new Exception("Невозможная атка");
                switch (type)
                {
                    case "SandAttack":
                    {

                        Staty tmp = SandAttack().Item2;
                        return  Tuple.Create(SandAttack().Item1, tmp);
                    }
                    case "HitInStomach":
                    {

                        Staty tmp = HitInStomach().Item2;
                        return  Tuple.Create(HitInStomach().Item1, tmp);
                    }
                    case "HitOnLeftHeand":
                    {

                        Staty tmp = HitOnLeftHeand().Item2;
                        return  Tuple.Create(HitOnLeftHeand().Item1, tmp);
                    }
                    case "HitOnLeg":
                    {

                        Staty tmp = HitOnLeg().Item2;
                        return  Tuple.Create(HitOnLeg().Item1, tmp);
                    }
                    
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

            return null;
        }
    }
}