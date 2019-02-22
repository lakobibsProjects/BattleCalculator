using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AttackCalculatorModel.Stats;

namespace AttackCalculatorModel.AdditionalVariables
{
    /// <summary>
    /// класс, задающий базовую функциональность для связных переменных
    /// </summary>
    abstract class AbstractDependencyVariable : IVariable
    {
        abstract public string Name { get; set; }
        abstract public int AttackModifire { get; set; }
        abstract public int DamageModifire { get;set ; }
        abstract public bool IsActive { get; set; }                   
        abstract public IDictionary<StatNames, int>[] StatsDependencys { get; set; }

        /// <summary>
        /// метод-маркер, позволяющий определить влияет ли связная переменная на базовые переменные
        /// </summary>
        /// <returns></returns>
        public bool HasStatDependencys()
        {
            return StatsDependencys.Count() == 0 ? false : true;             
        }

        public AbstractDependencyVariable(string name)
        {
            Name = name;
            AttackModifire = 0;
            DamageModifire = 0;
            IsActive = false;            
        }
    }
}
