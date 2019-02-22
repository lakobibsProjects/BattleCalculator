using AttackCalculatorModel.Stats;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttackCalculatorModel.Conditions
{
    public interface ICondition
    {
        int attackChangeValue{ get; set; }
        int damageChangeValue { get; set; }
        IDictionary<StatNames, int>[] statsChangeValue();
    }
}
