using AttackCalculatorModel.Stats;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttackCalculatorModel.AdditionalVariables
{
    /// <summary>
    /// описывает свойства и методы класса, который должен обрабатывать связную переменную 
    /// и в соответствии с этим изменять базовые переменные и оказывать влияние на калькуляцию
    /// </summary>
    public interface IVariable
    {
        string Name { get; set; }
        int AttackModifire { get; set; }
        int DamageModifire { get; set; }
        bool IsActive { get; set; }
        bool HasStatDependencys();
        IDictionary<StatNames, int>[] StatsDependencys { get; set; }
    }
}
