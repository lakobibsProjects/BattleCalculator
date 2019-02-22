using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttackCalculatorModel.Stats
{
    /// <summary>
    /// класс описывает основные свойства детерминированных базовых переменных
    /// </summary>
    class AbilityStat : IStat
    {
        #region Constants
        private const int minAbilityValue = 0;
        private const int maxAbilityValue = 50;
        #endregion

        #region Properties
        private int _value;
        public int Value
        {
            get { return _value; }
            set
            {
                _value = value;
                if (value < minAbilityValue)
                    this._value = minAbilityValue;
                if (value > maxAbilityValue)
                    this._value = maxAbilityValue;                                    
            }

        }

        private string name;
        public string Name { get => name; set => name = value; }
        #endregion

        #region Constructors
        public AbilityStat()
        {
            name = "";
            _value = 0;
        }

        public AbilityStat(int value)
        {
            _value = value;
        }

        public AbilityStat(string name)
        {
            this.name = name;
            _value = 0;
        }

        public AbilityStat(string name, int value)
        {
            this.name = name;
            _value = value;
        }
        #endregion
    }
}
