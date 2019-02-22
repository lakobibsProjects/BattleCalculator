using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttackCalculatorModel.Stats
{
    public interface IStat
    {
        int Value { get; set; }
        string Name { get; set; }
    }
}
