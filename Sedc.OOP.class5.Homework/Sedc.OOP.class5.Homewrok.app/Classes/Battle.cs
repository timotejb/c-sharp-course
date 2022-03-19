using System;
using System.Collections.Generic;
using System.Text;

namespace Sedc.OOP.class5.Homewrok.app.Classes
{
    class Battle
    {
        public static bool Calculate(CanBattle entity, CanBattle entity1)
        {

            return entity.PowerLevel > entity1.PowerLevel;
        }
    }
}
