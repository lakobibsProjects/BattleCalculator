using Prism.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PathfinderBattleCaclculatorC
{
    public class ConditionsVM
    {
        class ConditionState
        {
            public string Name { get; }
            public bool Isgained;
        }

        public class ConditionsCollection : List<ConditionsVM>
        {
            public ConditionsCollection() { }
        }

    }


}
