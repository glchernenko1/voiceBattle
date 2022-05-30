using System;

namespace ConsoleApplication2
{
    public class Defense: Staty
    {
        public override  Tuple <int, Staty>  GetHit(int hit, Staty stay)
        {
            if (rnd.Next(0, 10) < 4)
                return Tuple.Create(hit, stay);
            return Tuple.Create(0, new Staty());
        }
    }
}