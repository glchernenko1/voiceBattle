using System.Collections.Generic;

namespace ConsoleApplication2
{
    public class HitLeg: Staty
    {
        public override List<string> GetListActiveAbility()
        {
            return new List<string> (new string[] {"SandAttack",  "HitOnLeftHeand", "HitOnLeg"});
        }
    }
}