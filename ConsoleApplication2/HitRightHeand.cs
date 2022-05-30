using System.Collections.Generic;

namespace ConsoleApplication2
{
    public class HitRightHeand: Staty
    {
        public override List<string> GetListActiveAbility()
        {
            return new List<string> (new string[] {"SandAttack", "HitInStomach", "HitOnLeg"});
        }
    }
}