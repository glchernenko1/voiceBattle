using System;

namespace ConsoleApplication2
{
    public class SandInEyes : Staty
    {
        public override Tuple<int, Staty> Attack(string type)
        {
            if (rnd.Next(0, 10) > 4)
            {
                return this.AttackSpal(type);
            }
            return Tuple.Create(0, new Staty());
        }
    }
}