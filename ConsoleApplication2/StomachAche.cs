using System.Collections.Generic;

namespace ConsoleApplication2
{
    public class StomachAche: Staty
    {
        public override List<string> GetListActiveAbility()
        {
            return new List<string> (new string[] { "HitInStomach", "HitOnLeftHeand", "HitOnLeg"});
        }
    }
}